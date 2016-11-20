namespace CanteenFoodOrdering
{
    partial class Start
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
            this.lb1 = new System.Windows.Forms.Label();
            this.btn1StartOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.Color.Gainsboro;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb1.Location = new System.Drawing.Point(192, 60);
            this.lb1.Name = "lb1";
            this.lb1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb1.Size = new System.Drawing.Size(671, 83);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Central Canteen ";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn1StartOrder
            // 
            this.btn1StartOrder.Location = new System.Drawing.Point(424, 281);
            this.btn1StartOrder.Name = "btn1StartOrder";
            this.btn1StartOrder.Size = new System.Drawing.Size(209, 77);
            this.btn1StartOrder.TabIndex = 2;
            this.btn1StartOrder.Text = "Start Order";
            this.btn1StartOrder.UseVisualStyleBackColor = true;
            this.btn1StartOrder.Click += new System.EventHandler(this.btn1StartOrder_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CanteenFoodOrdering.Properties.Resources.veg2;
            this.ClientSize = new System.Drawing.Size(1027, 615);
            this.Controls.Add(this.btn1StartOrder);
            this.Controls.Add(this.lb1);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btn1StartOrder;
    }
}