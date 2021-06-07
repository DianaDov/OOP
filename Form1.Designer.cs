
namespace oop3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.generalPanel = new System.Windows.Forms.Panel();
            this.velZBox = new System.Windows.Forms.TextBox();
            this.velYBox = new System.Windows.Forms.TextBox();
            this.velXBox = new System.Windows.Forms.TextBox();
            this.posZBox = new System.Windows.Forms.TextBox();
            this.posYBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.posXBox = new System.Windows.Forms.TextBox();
            this.massBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.starPanel = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.classBox = new System.Windows.Forms.ComboBox();
            this.temberatureBox = new System.Windows.Forms.TextBox();
            this.gasGiantPanel = new System.Windows.Forms.Panel();
            this.coreRadiusBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.liquidLayerRadiusBox = new System.Windows.Forms.TextBox();
            this.cometPanel = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.comaRadiusBox = new System.Windows.Forms.TextBox();
            this.comaBox = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tailBox = new System.Windows.Forms.TextBox();
            this.newButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.planetRadiusBox = new System.Windows.Forms.TextBox();
            this.planetPanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.generalPanel.SuspendLayout();
            this.starPanel.SuspendLayout();
            this.gasGiantPanel.SuspendLayout();
            this.cometPanel.SuspendLayout();
            this.planetPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalPanel
            // 
            this.generalPanel.Controls.Add(this.velZBox);
            this.generalPanel.Controls.Add(this.velYBox);
            this.generalPanel.Controls.Add(this.velXBox);
            this.generalPanel.Controls.Add(this.posZBox);
            this.generalPanel.Controls.Add(this.posYBox);
            this.generalPanel.Controls.Add(this.label13);
            this.generalPanel.Controls.Add(this.label14);
            this.generalPanel.Controls.Add(this.label15);
            this.generalPanel.Controls.Add(this.label16);
            this.generalPanel.Controls.Add(this.label6);
            this.generalPanel.Controls.Add(this.label5);
            this.generalPanel.Controls.Add(this.label4);
            this.generalPanel.Controls.Add(this.label3);
            this.generalPanel.Controls.Add(this.label2);
            this.generalPanel.Controls.Add(this.label1);
            this.generalPanel.Controls.Add(this.posXBox);
            this.generalPanel.Controls.Add(this.massBox);
            this.generalPanel.Controls.Add(this.nameBox);
            this.generalPanel.Location = new System.Drawing.Point(187, 12);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(329, 154);
            this.generalPanel.TabIndex = 1;
            // 
            // velZBox
            // 
            this.velZBox.Location = new System.Drawing.Point(242, 133);
            this.velZBox.Name = "velZBox";
            this.velZBox.Size = new System.Drawing.Size(79, 20);
            this.velZBox.TabIndex = 28;
            this.velZBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNonDigits);
            // 
            // velYBox
            // 
            this.velYBox.Location = new System.Drawing.Point(135, 133);
            this.velYBox.Name = "velYBox";
            this.velYBox.Size = new System.Drawing.Size(79, 20);
            this.velYBox.TabIndex = 27;
            this.velYBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNonDigits);
            // 
            // velXBox
            // 
            this.velXBox.Location = new System.Drawing.Point(20, 133);
            this.velXBox.Name = "velXBox";
            this.velXBox.Size = new System.Drawing.Size(79, 20);
            this.velXBox.TabIndex = 26;
            this.velXBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNonDigits);
            // 
            // posZBox
            // 
            this.posZBox.Location = new System.Drawing.Point(242, 79);
            this.posZBox.Name = "posZBox";
            this.posZBox.Size = new System.Drawing.Size(80, 20);
            this.posZBox.TabIndex = 25;
            this.posZBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNonDigits);
            // 
            // posYBox
            // 
            this.posYBox.Location = new System.Drawing.Point(135, 79);
            this.posYBox.Name = "posYBox";
            this.posYBox.Size = new System.Drawing.Size(80, 20);
            this.posYBox.TabIndex = 24;
            this.posYBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNonDigits);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(222, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Z";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(115, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Y";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "X";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Скорость";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Координаты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Масса";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название";
            // 
            // posXBox
            // 
            this.posXBox.Location = new System.Drawing.Point(20, 79);
            this.posXBox.Name = "posXBox";
            this.posXBox.Size = new System.Drawing.Size(79, 20);
            this.posXBox.TabIndex = 2;
            this.posXBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNonDigits);
            // 
            // massBox
            // 
            this.massBox.Location = new System.Drawing.Point(63, 29);
            this.massBox.Name = "massBox";
            this.massBox.Size = new System.Drawing.Size(266, 20);
            this.massBox.TabIndex = 1;
            this.massBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNonDigits);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(63, 3);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(266, 20);
            this.nameBox.TabIndex = 0;
            // 
            // starPanel
            // 
            this.starPanel.Controls.Add(this.label19);
            this.starPanel.Controls.Add(this.label18);
            this.starPanel.Controls.Add(this.classBox);
            this.starPanel.Controls.Add(this.temberatureBox);
            this.starPanel.Location = new System.Drawing.Point(103, 201);
            this.starPanel.Name = "starPanel";
            this.starPanel.Size = new System.Drawing.Size(498, 50);
            this.starPanel.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(299, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Класс";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(81, 2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 26);
            this.label18.TabIndex = 28;
            this.label18.Text = "Температура\r\nповерхности";
            // 
            // classBox
            // 
            this.classBox.FormattingEnabled = true;
            this.classBox.Location = new System.Drawing.Point(343, 25);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(64, 21);
            this.classBox.TabIndex = 10;
            // 
            // temberatureBox
            // 
            this.temberatureBox.Location = new System.Drawing.Point(163, 1);
            this.temberatureBox.Name = "temberatureBox";
            this.temberatureBox.Size = new System.Drawing.Size(244, 20);
            this.temberatureBox.TabIndex = 9;
            this.temberatureBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNonDigits);
            // 
            // gasGiantPanel
            // 
            this.gasGiantPanel.Controls.Add(this.coreRadiusBox);
            this.gasGiantPanel.Controls.Add(this.label7);
            this.gasGiantPanel.Controls.Add(this.label20);
            this.gasGiantPanel.Controls.Add(this.liquidLayerRadiusBox);
            this.gasGiantPanel.Location = new System.Drawing.Point(122, 203);
            this.gasGiantPanel.Name = "gasGiantPanel";
            this.gasGiantPanel.Size = new System.Drawing.Size(431, 58);
            this.gasGiantPanel.TabIndex = 3;
            // 
            // coreRadiusBox
            // 
            this.coreRadiusBox.Location = new System.Drawing.Point(143, 28);
            this.coreRadiusBox.Name = "coreRadiusBox";
            this.coreRadiusBox.Size = new System.Drawing.Size(249, 20);
            this.coreRadiusBox.TabIndex = 33;
            this.coreRadiusBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNonDigits);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Радиус ядра";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(62, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 13);
            this.label20.TabIndex = 31;
            this.label20.Text = "Радиус жидкого слоя";
            // 
            // liquidLayerRadiusBox
            // 
            this.liquidLayerRadiusBox.Location = new System.Drawing.Point(187, 2);
            this.liquidLayerRadiusBox.Name = "liquidLayerRadiusBox";
            this.liquidLayerRadiusBox.Size = new System.Drawing.Size(205, 20);
            this.liquidLayerRadiusBox.TabIndex = 30;
            this.liquidLayerRadiusBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNonDigits);
            // 
            // cometPanel
            // 
            this.cometPanel.Controls.Add(this.label22);
            this.cometPanel.Controls.Add(this.comaRadiusBox);
            this.cometPanel.Controls.Add(this.comaBox);
            this.cometPanel.Controls.Add(this.label21);
            this.cometPanel.Controls.Add(this.tailBox);
            this.cometPanel.Location = new System.Drawing.Point(151, 171);
            this.cometPanel.Name = "cometPanel";
            this.cometPanel.Size = new System.Drawing.Size(375, 53);
            this.cometPanel.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(101, 29);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 13);
            this.label22.TabIndex = 36;
            this.label22.Text = "Радиус комы";
            // 
            // comaRadiusBox
            // 
            this.comaRadiusBox.Location = new System.Drawing.Point(181, 26);
            this.comaRadiusBox.Name = "comaRadiusBox";
            this.comaRadiusBox.Size = new System.Drawing.Size(185, 20);
            this.comaRadiusBox.TabIndex = 35;
            this.comaRadiusBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNonDigits);
            // 
            // comaBox
            // 
            this.comaBox.AutoSize = true;
            this.comaBox.Location = new System.Drawing.Point(41, 28);
            this.comaBox.Name = "comaBox";
            this.comaBox.Size = new System.Drawing.Size(53, 17);
            this.comaBox.TabIndex = 34;
            this.comaBox.Text = "Кома";
            this.comaBox.UseVisualStyleBackColor = true;
            this.comaBox.CheckedChanged += new System.EventHandler(this.comaBox_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(40, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "Длина хвоста";
            // 
            // tailBox
            // 
            this.tailBox.Location = new System.Drawing.Point(122, 0);
            this.tailBox.Name = "tailBox";
            this.tailBox.Size = new System.Drawing.Size(244, 20);
            this.tailBox.TabIndex = 32;
            this.tailBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNonDigits);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(103, 12);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 4;
            this.newButton.Text = "Новое тело";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(103, 305);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(107, 23);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Десериализовать";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(103, 275);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сериализовать";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(368, 299);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "Сохранить";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(451, 299);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // planetRadiusBox
            // 
            this.planetRadiusBox.Location = new System.Drawing.Point(62, 10);
            this.planetRadiusBox.Name = "planetRadiusBox";
            this.planetRadiusBox.Size = new System.Drawing.Size(266, 20);
            this.planetRadiusBox.TabIndex = 8;
            this.planetRadiusBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNonDigits);
            // 
            // planetPanel
            // 
            this.planetPanel.Controls.Add(this.label17);
            this.planetPanel.Controls.Add(this.planetRadiusBox);
            this.planetPanel.Location = new System.Drawing.Point(186, 167);
            this.planetPanel.Name = "planetPanel";
            this.planetPanel.Size = new System.Drawing.Size(328, 30);
            this.planetPanel.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Радиус";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(85, 316);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 340);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.planetPanel);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.generalPanel);
            this.Controls.Add(this.cometPanel);
            this.Controls.Add(this.starPanel);
            this.Controls.Add(this.gasGiantPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.generalPanel.ResumeLayout(false);
            this.generalPanel.PerformLayout();
            this.starPanel.ResumeLayout(false);
            this.starPanel.PerformLayout();
            this.gasGiantPanel.ResumeLayout(false);
            this.gasGiantPanel.PerformLayout();
            this.cometPanel.ResumeLayout(false);
            this.cometPanel.PerformLayout();
            this.planetPanel.ResumeLayout(false);
            this.planetPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel generalPanel;
        private System.Windows.Forms.Panel starPanel;
        private System.Windows.Forms.Panel gasGiantPanel;
        private System.Windows.Forms.Panel cometPanel;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox posXBox;
        private System.Windows.Forms.TextBox massBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox classBox;
        private System.Windows.Forms.TextBox temberatureBox;
        private System.Windows.Forms.TextBox planetRadiusBox;
        private System.Windows.Forms.Panel planetPanel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox liquidLayerRadiusBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox comaRadiusBox;
        private System.Windows.Forms.CheckBox comaBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tailBox;
        private System.Windows.Forms.TextBox velZBox;
        private System.Windows.Forms.TextBox velYBox;
        private System.Windows.Forms.TextBox velXBox;
        private System.Windows.Forms.TextBox posZBox;
        private System.Windows.Forms.TextBox posYBox;
        private System.Windows.Forms.TextBox coreRadiusBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

