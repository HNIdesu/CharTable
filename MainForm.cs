using System.Text;
using System.Text.Json.Nodes;

namespace CharTable
{
    public partial class MainForm : Form
    {
        private static readonly string UserListPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "userlist.json");

        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {

        }


        private void LoadDataBase()
        {
            if (!File.Exists(ResourceManager.DatabasePath)) return;
            var list = ResourceManager.Instance.GetAllFonts();
            {
                FontListPanel fontListPanel = new FontListPanel();
                fontListPanel.OnFontRightClick += FontListPanel_OnFontRightClick;
                fontListPanel.OnFontMouseEnter += FontListPanel_OnFontMouseEnter;
                fontListPanel.OnFontMouseLeave += FontListPanel_OnFontMouseLeave;
                fontListPanel.AddItems(list);
                ResourceManager.Instance.RegisterObserver(fontListPanel);
                AddFontListTab("全部", fontListPanel);

                fontListPanel = new OftenUseFontListPanel();
                fontListPanel.OnFontRightClick += FontListPanel_OnFontRightClick;
                fontListPanel.OnFontMouseEnter += FontListPanel_OnFontMouseEnter;
                fontListPanel.OnFontMouseLeave += FontListPanel_OnFontMouseLeave;
                ResourceManager.Instance.RegisterObserver(fontListPanel);
                AddFontListTab("常用", fontListPanel);

                fontListPanel = new CollectionFontListPanel();
                fontListPanel.OnFontRightClick += FontListPanel_OnFontRightClick;
                fontListPanel.OnFontMouseEnter += FontListPanel_OnFontMouseEnter;
                fontListPanel.OnFontMouseLeave += FontListPanel_OnFontMouseLeave;
                ResourceManager.Instance.RegisterObserver(fontListPanel);
                AddFontListTab("收藏", fontListPanel);
            }


            JsonNode? root = JsonNode.Parse(File.ReadAllText(UserListPath, Encoding.UTF8));
            if (root == null) return;
            try
            {
                string? version = root["version"]?.GetValue<string>();
                if (version == "1.0")
                {
                    JsonArray? groups = root["groups"]?.AsArray();
                    if (groups == null) return;
                    foreach (JsonNode? group in groups)
                    {
                        if (group == null) continue;
                        FontListPanel fontListPanel = new FontListPanel();
                        fontListPanel.OnFontRightClick += FontListPanel_OnFontRightClick;
                        fontListPanel.OnFontMouseEnter += FontListPanel_OnFontMouseEnter;
                        fontListPanel.OnFontMouseLeave += FontListPanel_OnFontMouseLeave;
                        AddFontListTab((group["header"]?.GetValue<string>()) ?? "", fontListPanel);
                        JsonArray? items = group["items"]?.AsArray();
                        if (items == null) return;
                        foreach (JsonNode? item in items)
                        {
                            if (item != null)
                            {
                                char? code = item.GetValue<char>();
                                if (code != null)
                                {
                                    if (list.Any(s => s.Char == code))
                                        fontListPanel.AddItems(list.Where(s => s.Char == code));
                                    else
                                        ResourceManager.Instance.InsertFont(code.Value, null);
                                }

                            }
                        }


                    }
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("读取数据库文件失败");
                return;
            }


        }


        private void AddFontListTab(string header, FontListPanel fontListPanel)
        {
            Panel panel = new Panel();
            panel.AutoScroll = true;
            panel.Dock = DockStyle.Fill;
            panel.Controls.Add(fontListPanel);
            TabPage tabPage = new TabPage(header) { BackColor = Color.White };
            tabPage.Controls.Add(panel);
            tabControl1.TabPages.Add(tabPage);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataBase();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string keyword = textBox_Search.Text;
            if (string.IsNullOrEmpty(keyword)) return;
            FontListPanel fontListPanel = new FontListPanel();
            fontListPanel.OnFontRightClick += FontListPanel_OnFontRightClick;
            fontListPanel.OnFontMouseEnter += FontListPanel_OnFontMouseEnter;
            fontListPanel.OnFontMouseLeave += FontListPanel_OnFontMouseLeave;
            fontListPanel.AddItems(ResourceManager.Instance.SearchFonts(keyword));
            AddFontListTab($"搜索\"{textBox_Search.Text}\"的结果", fontListPanel);

        }

        private void FontListPanel_OnFontMouseLeave(object? sender, Item e)
        {

        }

        private void FontListPanel_OnFontMouseEnter(object? sender, Item e)
        {
            toolStripStatusLabel_Info.Text = $"{e.Char} U+{string.Format("{0:X4}", (int)e.Char)}";
        }

        private void FontListPanel_OnFontRightClick(object? sender, Item e)
        {
            if (e.IsLike)
                toolStripMenuItem_Mark.Text = "取消收藏";
            else
                toolStripMenuItem_Mark.Text = "收藏";
            fontRightClickContextMenuStrip.Show(MousePosition);
            fontRightClickContextMenuStrip.Tag = e;
        }

        private void fontRightClickContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == toolStripMenuItem_Copy)
            {
                Item item = (Item)fontRightClickContextMenuStrip.Tag;
                item.UseCount++;
                Clipboard.SetText($"{item.Char}");
                ResourceManager.Instance.UpdateFont(item);
            }
            else if (e.ClickedItem == toolStripMenuItem_Mark)
            {
                Item item = (Item)fontRightClickContextMenuStrip.Tag;
                item.IsLike = !item.IsLike;
                ResourceManager.Instance.UpdateFont(item);
            }
        }
    }
}