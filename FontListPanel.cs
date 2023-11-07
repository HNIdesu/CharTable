
using System.Collections;

namespace CharTable
{
    internal class FontListPanel:FlowLayoutPanel,Observer<Item>
    {
        public event EventHandler<Item> OnFontRightClick = delegate { };
        public event EventHandler<Item> OnFontMouseEnter = delegate { };
        public event EventHandler<Item> OnFontMouseLeave = delegate { };
        protected Dictionary<Item, Control> DataBinding { get; set; } = new Dictionary<Item, Control>();
        public FontListPanel()
        {
            Dock = DockStyle.Fill;
            AutoScroll = true;
        }
        public void AddItem(Item font)
        {
            if (!DataBinding.ContainsKey(font))
            {
                var lb = CreateLabel(font);
                Controls.Add(lb);
                DataBinding.Add(font, lb);
            }
            
        }

        private Label CreateLabel(Item font)
        {
            Label lb = new Label();
            lb.Size = new Size(50, 50);
            lb.BorderStyle = BorderStyle.FixedSingle;
            lb.TextAlign = ContentAlignment.MiddleCenter;
            lb.Font = new Font(FontFamily.GenericSerif, 30, FontStyle.Regular);
            lb.Text = font.Char.ToString();
            lb.Tag = font;
            lb.MouseClick += Lb_MouseClick;
            lb.MouseEnter += Lb_MouseEnter;
            lb.MouseLeave += Lb_MouseLeave;
            return lb;
        }

        public void InsertItem(Item font,int index)
        {
            var lb = CreateLabel(font);
            ((IList)Controls).Insert(index,lb);
            DataBinding.Add(font, lb);
        }

        public void ClearItems()
        {
            Controls.Clear();
            DataBinding.Clear();
        }

        public void RemoveItem(Item font)
        {
            if (DataBinding.ContainsKey(font))
            {
                Controls.Remove(DataBinding[font]);
                DataBinding.Remove(font);
            }
        }

        public void AddItems(IEnumerable<Item> fonts)
        {
            fonts.All((i) =>
            {
                AddItem(i);
                return true;
            });
        }


        private void Lb_MouseLeave(object? sender, EventArgs e)
        {
            if (sender == null)
                return;
            OnFontMouseLeave(this, (Item)((Label)sender).Tag);
        }

        private void Lb_MouseEnter(object? sender, EventArgs e)
        {
            if (sender == null)
                return;
            OnFontMouseEnter(this, (Item)((Label)sender).Tag);
        }

        private void Lb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (sender == null)
                return;
            if (e.Button == MouseButtons.Right)
                OnFontRightClick(this, (Item)((Label)sender).Tag);
        }

        public virtual void OnItemInserted(object sender, Item status)
        {
            AddItem(status);
        }

        public virtual void OnItemRemoved(object sender, Item status)
        {
            RemoveItem(status); 
        }

        public virtual void OnItemUpdated(object sender, Item status)
        {
            
        }

        public virtual void OnBatchModified(object? sender)
        {
            
        }
    }
}
