
namespace InfiniteRunner
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent() {
            this.gameArea1 = new InfiniteRunner.GameArea();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameArea1
            // 
            this.gameArea1.Location = new System.Drawing.Point(12, 38);
            this.gameArea1.Name = "gameArea1";
            this.gameArea1.Size = new System.Drawing.Size(351, 151);
            this.gameArea1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skóre: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameArea1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private GameArea gameArea1;
        private System.Windows.Forms.Label label1;
    }
}

