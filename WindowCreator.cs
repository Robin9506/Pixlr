using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixlr
{
    class WindowCreator
    {

        public Window CreateParentWindow() {
            Window form = new Window();

            form.Text = "Pixlr";
            form.WindowState = FormWindowState.Maximized;
            form.IsMdiContainer = true;

            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem windowMenu = new ToolStripMenuItem("File");
            menuStrip.Items.Add(windowMenu);
            menuStrip.Dock = DockStyle.Bottom;

            form.Controls.Add(menuStrip);

            return form;

        }

        public Window CreateWindow(Window parentForm)
        {
            Window form = new Window();
            Button button = new Button();

            button.Text = "Child";
            button.Location = new System.Drawing.Point(50, 50);

            form.MdiParent = parentForm;
            form.FormBorderStyle = FormBorderStyle.None;

            form.Controls.Add(button);
            form.Dock = DockStyle.Right;
            form.Show();
            return form;

        }
    }
}
