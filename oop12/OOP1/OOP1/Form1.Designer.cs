
namespace OOP1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.squareItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arcItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1077, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.squareItem,
            this.rectangleItem,
            this.circleItem,
            this.ellipseItem,
            this.arcItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuItem1.Text = "Shape";
            // 
            // squareItem
            // 
            this.squareItem.Name = "squareItem";
            this.squareItem.Size = new System.Drawing.Size(126, 22);
            this.squareItem.Text = "Square";
            // 
            // rectangleItem
            // 
            this.rectangleItem.Name = "rectangleItem";
            this.rectangleItem.Size = new System.Drawing.Size(126, 22);
            this.rectangleItem.Text = "Rectangle";
            // 
            // circleItem
            // 
            this.circleItem.Name = "circleItem";
            this.circleItem.Size = new System.Drawing.Size(126, 22);
            this.circleItem.Text = "Circle";
            // 
            // ellipseItem
            // 
            this.ellipseItem.Name = "ellipseItem";
            this.ellipseItem.Size = new System.Drawing.Size(126, 22);
            this.ellipseItem.Text = "Ellipse";
            // 
            // arcItem
            // 
            this.arcItem.Name = "arcItem";
            this.arcItem.Size = new System.Drawing.Size(126, 22);
            this.arcItem.Text = "Arc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 696);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem squareItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem rectangleItem;
        private System.Windows.Forms.ToolStripMenuItem circleItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseItem;
        private System.Windows.Forms.ToolStripMenuItem arcItem;
    }
}

