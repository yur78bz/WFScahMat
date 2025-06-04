using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFShahMat
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();           
        }

        private void txtKing_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string king=txtKing.Text.Trim(); 
            string[] rooks = new string[3];
            rooks[0] = txtRooks1.Text.Trim();
            rooks[1] = txtRooks2.Text.Trim();
            rooks[2] = txtRooks3.Text.Trim();

            // проверка корректности ввода координат короля
            if (!IsValidPosition(king))
            {
                MessageBox.Show("Не кооректные координаты короля. Введите значение в формате a1-h8");
                return;
            }

            //  проверка корректности ввода координат ладей
            foreach (var rook in rooks)
            {
                if (!IsValidPosition(rook))
                {
                    MessageBox.Show($"Не кооректные координаты ладьи. Введите значение в формате a1-h8");
                    return;
                }
            }
            // проверяем находится ли король под боем
            List<string> threats = new List<string>();

            foreach (var rook in rooks)
            {
                if (IsUnderThreat(king, rook))
                {
                    threats.Add(rook);
                }

                // Выводим результат
                if (threats.Count>0)
                {
                    lbMessage.Visible = true;
                    lbMessage.Text = "Король под боем от ладей: " + string.Join(", ", threats);
                }
                else
                {
                    lbMessage.Visible = true;
                    lbMessage.Text = "Король не под боем";
                }
            }
        }

        //Метод для проверки,находится ли король под угрозой ладьи
        private bool IsUnderThreat(string king, string rook)
        {
            // проверяем что координаты корректны
            if (king.Length!=2|| rook.Length!=2)

                return false;
            char kingFile = king[0]; // a-h
            char kingRank = king[1]; // 1-8
            char rookFile = rook[0]; // a-h
            char rookRank = rook[1]; // 1-8

            //проверяем находятся ли король и ладья на одной линии

            return (kingFile == rookFile || kingRank == rookRank);            
        }

        // метод для проверки корректности ввода координат
        private bool IsValidPosition(string position)
        {
            // проверяется что длина строки равна 2
            if (position.Length != 2) return false;
            
            char file = position[0]; // первая буква (a-h)

            char rank = position[1]; // вторая цифра (1-8)

            // проверяется что первая буква находится в диапазоне от "а" до "h" и 
            // второе значение в диапазоне от 1 до 8
            return (file >= 'a' && file <='h' && rank>='1' && rank <='8');
        }  
    }
}
