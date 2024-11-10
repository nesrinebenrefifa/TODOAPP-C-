using System;

namespace WindowsFormsApp1
{
    partial class TodoList
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.NEWBUTT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.TITLE = new System.Windows.Forms.Label();
            this.EditBUTT = new System.Windows.Forms.Button();
            this.DELETBUTT = new System.Windows.Forms.Button();
            this.SAVEBUTT = new System.Windows.Forms.Button();
            this.toDoListView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListView)).BeginInit();
            this.SuspendLayout();
            // 
            // NEWBUTT
            // 
            this.NEWBUTT.Location = new System.Drawing.Point(32, 257);
            this.NEWBUTT.Name = "NEWBUTT";
            this.NEWBUTT.Size = new System.Drawing.Size(154, 43);
            this.NEWBUTT.TabIndex = 0;
            this.NEWBUTT.Text = "new";
            this.NEWBUTT.UseVisualStyleBackColor = true;
            this.NEWBUTT.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "To Do List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
          
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(839, 26);
            this.textBox1.TabIndex = 2;
           
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(839, 26);
            this.textBox2.TabIndex = 3;
            // 
            // Description
            // 
            //this.Description.Location = new System.Drawing.Point(28, 186);
            //this.Description.Name = "Description";
            //this.Description.Size = new System.Drawing.Size(100, 23);
            //this.Description.TabIndex = 4;
            //this.Description.Text = "description";
            //this.Description.Click += new System.EventHandler(this.label2_Click);
            // 
            // TITLE
            // 
            this.TITLE.Location = new System.Drawing.Point(28, 112);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(100, 23);
            this.TITLE.TabIndex = 5;
            this.TITLE.Text = "Title";
            // 
            // EditBUTT
            // 
            this.EditBUTT.Location = new System.Drawing.Point(256, 257);
            this.EditBUTT.Name = "EditBUTT";
            this.EditBUTT.Size = new System.Drawing.Size(154, 43);
            this.EditBUTT.TabIndex = 6;
            this.EditBUTT.Text = "Edit";
            this.EditBUTT.UseVisualStyleBackColor = true;
            this.EditBUTT.Click += new System.EventHandler(this.button2_Click);
            // 
            // DELETBUTT
            // 
            this.DELETBUTT.Location = new System.Drawing.Point(478, 257);
            this.DELETBUTT.Name = "DELETBUTT";
            this.DELETBUTT.Size = new System.Drawing.Size(154, 43);
            this.DELETBUTT.TabIndex = 7;
            this.DELETBUTT.Text = "Delete";
            this.DELETBUTT.UseVisualStyleBackColor = true;
            this.DELETBUTT.Click += new System.EventHandler(this.DELETBUTT_Click);
            // 
            // SAVEBUTT
            // 
            this.SAVEBUTT.Location = new System.Drawing.Point(690, 257);
            this.SAVEBUTT.Name = "SAVEBUTT";
            this.SAVEBUTT.Size = new System.Drawing.Size(154, 43);
            this.SAVEBUTT.TabIndex = 8;
            this.SAVEBUTT.Text = "Save";
            this.SAVEBUTT.UseVisualStyleBackColor = true;
            this.SAVEBUTT.Click += new System.EventHandler(this.SAVEBUTT_Click);
            // 
            // toDoListView
            // 
            this.toDoListView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toDoListView.Location = new System.Drawing.Point(32, 352);
            this.toDoListView.Name = "toDoListView";
            this.toDoListView.RowHeadersWidth = 62;
            this.toDoListView.RowTemplate.Height = 28;
            this.toDoListView.Size = new System.Drawing.Size(848, 235);
            this.toDoListView.TabIndex = 9;
            // 
            // TodoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(915, 705);
            this.Controls.Add(this.toDoListView);
            this.Controls.Add(this.SAVEBUTT);
            this.Controls.Add(this.DELETBUTT);
            this.Controls.Add(this.EditBUTT);
            this.Controls.Add(this.TITLE);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NEWBUTT);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "TodoList";
            this.Text = "TodoList";
            this.TransparencyKey = System.Drawing.Color.RosyBrown;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toDoListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion
        private System.Windows.Forms.Button NEWBUTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label TITLE;
        private System.Windows.Forms.Button EditBUTT;
        private System.Windows.Forms.Button DELETBUTT;
        private System.Windows.Forms.Button SAVEBUTT;
        private System.Windows.Forms.DataGridView toDoListView;
        private EventHandler label1_Click;
        private EventHandler textBox1_TextChanged;
        private EventHandler label2_Click;
    }
}

