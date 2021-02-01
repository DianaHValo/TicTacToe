using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;

namespace TicTacToe
{
    public class Model
    {
        public int click = 1;

        public string topLeft;
        public string topCenter;
        public string topRight;

        public string middleLeft;
        public string middleCenter;
        public string middleRight;

        public string bottomLeft;
        public string bottomCenter;
        public string bottomRight;


        public string BtnClick(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                if (click % 2 == 0)
                {
                    content = "0";
                    click++;
                }
                else
                {
                    content = "X";
                    click++;
                }
            }
            return content;
        }
        public void checkVictory()
        {
            CheckVictoryConditionsRow();
            CheckVictoryConditionsColumn();
            CheckVictoryConditionsDiagonally();
        }

        private void CheckVictoryConditionsRow()
        {
            if ((topLeft == topCenter && topRight == topCenter) && topLeft !=null)
            {
                if (topLeft == "X")
                {
                    MessageBox.Show("X won");
                }
                else
                {
                    MessageBox.Show("0 won");
                }
            }
            if ((middleLeft == middleCenter && middleCenter == middleRight) && middleLeft != null)
            {

                if (middleLeft == "X")
                {
                    MessageBox.Show("X won");
                }
                else
                {
                    MessageBox.Show("0 won");
                }
            }
            if ((bottomLeft == bottomCenter && bottomRight == bottomCenter) && bottomLeft != null)
            {

                if (bottomLeft == "X")
                {
                    MessageBox.Show("X won");
                }
                else
                {
                    MessageBox.Show("0 won");
                }
            }
        }
        private void CheckVictoryConditionsColumn()
        {
            if ((topLeft == middleLeft && bottomLeft == middleLeft) && topLeft != null)
            {

                if (topLeft == "X")
                {
                    MessageBox.Show("X won");
                }
                else
                {
                    MessageBox.Show("0 won");
                }
            }
            if ((topCenter ==  middleCenter && bottomCenter == middleCenter) && topCenter!= null)
            {

                if (topCenter == "X")
                {
                    MessageBox.Show("X won");
                }
                else
                {
                    MessageBox.Show("0 won");
                }
            }
            if ((topRight == middleRight&& bottomRight == middleRight) && topRight!= null)
            {

                if (topRight == "X")
                {
                    MessageBox.Show("X won");
                }
                else
                {
                    MessageBox.Show("0 won");
                }
            }
        }
        private void CheckVictoryConditionsDiagonally()
        {
            if ((topLeft == middleCenter && bottomRight == middleCenter) && topLeft != null)
            {

                if (topLeft == "X")
                {
                    MessageBox.Show("X won");
                }
                else
                {
                    MessageBox.Show("0 won");
                }
            }
            if ((topRight == middleCenter&& bottomLeft == middleCenter) && topRight != null)
            {

                if (topRight == "X")
                {
                    MessageBox.Show("X won");
                }
                else
                {
                    MessageBox.Show("0 won");
                }
            }
        }
        public void Reset()
        {
         click = 1;

         topLeft=null;
         topCenter = null;
         topRight = null;

         middleLeft = null;
         middleCenter = null;
         middleRight = null;

         bottomLeft = null;
         bottomCenter = null;
         bottomRight = null;
    }


    }
    }

