﻿namespace ExelApplication
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filetoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.savetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opentoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exittoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Applybutton1 = new System.Windows.Forms.Button();
            this.Clearbutton2 = new System.Windows.Forms.Button();
            this.AddRowbutton3 = new System.Windows.Forms.Button();
            this.AddColumnbutton4 = new System.Windows.Forms.Button();
            this.DeleteRowbutton5 = new System.Windows.Forms.Button();
            this.DeleteColumnbutton6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 376);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dataGridView1_CellParsing);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filetoolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filetoolStripMenuItem1
            // 
            this.filetoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savetoolStripMenuItem,
            this.opentoolStripMenuItem,
            this.exittoolStripMenuItem});
            this.filetoolStripMenuItem1.Name = "filetoolStripMenuItem1";
            this.filetoolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.filetoolStripMenuItem1.Text = "File";
            this.filetoolStripMenuItem1.Click += new System.EventHandler(this.filetoolStripMenuItem1_Click);
            // 
            // savetoolStripMenuItem
            // 
            this.savetoolStripMenuItem.Name = "savetoolStripMenuItem";
            this.savetoolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.savetoolStripMenuItem.Text = "Save";
            this.savetoolStripMenuItem.Click += new System.EventHandler(this.savetoolStripMenuItem_Click);
            // 
            // opentoolStripMenuItem
            // 
            this.opentoolStripMenuItem.Name = "opentoolStripMenuItem";
            this.opentoolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.opentoolStripMenuItem.Text = "Open";
            this.opentoolStripMenuItem.Click += new System.EventHandler(this.opentoolStripMenuItem_Click_1);
            // 
            // exittoolStripMenuItem
            // 
            this.exittoolStripMenuItem.Name = "exittoolStripMenuItem";
            this.exittoolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exittoolStripMenuItem.Text = "Exit";
            this.exittoolStripMenuItem.Click += new System.EventHandler(this.exittoolStripMenuItem_Click);
            // 
            // Applybutton1
            // 
            this.Applybutton1.Location = new System.Drawing.Point(0, 33);
            this.Applybutton1.Name = "Applybutton1";
            this.Applybutton1.Size = new System.Drawing.Size(91, 35);
            this.Applybutton1.TabIndex = 2;
            this.Applybutton1.Text = "Apply";
            this.Applybutton1.UseVisualStyleBackColor = true;
            this.Applybutton1.Click += new System.EventHandler(this.Applybutton1_Click);
            // 
            // Clearbutton2
            // 
            this.Clearbutton2.Location = new System.Drawing.Point(97, 33);
            this.Clearbutton2.Name = "Clearbutton2";
            this.Clearbutton2.Size = new System.Drawing.Size(91, 35);
            this.Clearbutton2.TabIndex = 3;
            this.Clearbutton2.Text = "Clear";
            this.Clearbutton2.UseVisualStyleBackColor = true;
            this.Clearbutton2.Click += new System.EventHandler(this.Clearbutton2_Click);
            // 
            // AddRowbutton3
            // 
            this.AddRowbutton3.Location = new System.Drawing.Point(381, 33);
            this.AddRowbutton3.Name = "AddRowbutton3";
            this.AddRowbutton3.Size = new System.Drawing.Size(91, 35);
            this.AddRowbutton3.TabIndex = 4;
            this.AddRowbutton3.Text = "Add Row";
            this.AddRowbutton3.UseVisualStyleBackColor = true;
            this.AddRowbutton3.Click += new System.EventHandler(this.AddRowbutton3_Click);
            // 
            // AddColumnbutton4
            // 
            this.AddColumnbutton4.Location = new System.Drawing.Point(478, 33);
            this.AddColumnbutton4.Name = "AddColumnbutton4";
            this.AddColumnbutton4.Size = new System.Drawing.Size(104, 35);
            this.AddColumnbutton4.TabIndex = 5;
            this.AddColumnbutton4.Text = "Add Column";
            this.AddColumnbutton4.UseVisualStyleBackColor = true;
            this.AddColumnbutton4.Click += new System.EventHandler(this.AddColumnbutton4_Click);
            // 
            // DeleteRowbutton5
            // 
            this.DeleteRowbutton5.Location = new System.Drawing.Point(588, 33);
            this.DeleteRowbutton5.Name = "DeleteRowbutton5";
            this.DeleteRowbutton5.Size = new System.Drawing.Size(91, 35);
            this.DeleteRowbutton5.TabIndex = 6;
            this.DeleteRowbutton5.Text = "Delete Row";
            this.DeleteRowbutton5.UseVisualStyleBackColor = true;
            this.DeleteRowbutton5.Click += new System.EventHandler(this.DeleteRowbutton5_Click);
            // 
            // DeleteColumnbutton6
            // 
            this.DeleteColumnbutton6.Location = new System.Drawing.Point(685, 33);
            this.DeleteColumnbutton6.Name = "DeleteColumnbutton6";
            this.DeleteColumnbutton6.Size = new System.Drawing.Size(115, 35);
            this.DeleteColumnbutton6.TabIndex = 7;
            this.DeleteColumnbutton6.Text = "Delete Column";
            this.DeleteColumnbutton6.UseVisualStyleBackColor = true;
            this.DeleteColumnbutton6.Click += new System.EventHandler(this.DeleteColumnbutton6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 22);
            this.textBox1.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DeleteColumnbutton6);
            this.Controls.Add(this.DeleteRowbutton5);
            this.Controls.Add(this.AddColumnbutton4);
            this.Controls.Add(this.AddRowbutton3);
            this.Controls.Add(this.Clearbutton2);
            this.Controls.Add(this.Applybutton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filetoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem savetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opentoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exittoolStripMenuItem;
        private System.Windows.Forms.Button Applybutton1;
        private System.Windows.Forms.Button Clearbutton2;
        private System.Windows.Forms.Button AddRowbutton3;
        private System.Windows.Forms.Button AddColumnbutton4;
        private System.Windows.Forms.Button DeleteRowbutton5;
        private System.Windows.Forms.Button DeleteColumnbutton6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

