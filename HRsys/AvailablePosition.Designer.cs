namespace HRsys
{
    partial class AvailablePosition
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.savePositionBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.positionLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(116, 194);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(557, 168);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Position";
            // 
            // savePositionBtn
            // 
            this.savePositionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePositionBtn.Location = new System.Drawing.Point(218, 117);
            this.savePositionBtn.Name = "savePositionBtn";
            this.savePositionBtn.Size = new System.Drawing.Size(261, 48);
            this.savePositionBtn.TabIndex = 8;
            this.savePositionBtn.Text = "Save Position";
            this.savePositionBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(218, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 31);
            this.textBox1.TabIndex = 7;
            // 
            // positionLbl
            // 
            this.positionLbl.AutoSize = true;
            this.positionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLbl.Location = new System.Drawing.Point(111, 66);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.Size = new System.Drawing.Size(101, 25);
            this.positionLbl.TabIndex = 6;
            this.positionLbl.Text = "Position :";
            // 
            // AvailablePosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 423);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.savePositionBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.positionLbl);
            this.Name = "AvailablePosition";
            this.Text = "AvailablePosition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button savePositionBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label positionLbl;
    }
}