using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика
{
    public partial class Пасьянс_Горем_Султана : Form
    {
        const int CARD_WIDTH = 72;    // ширина карты
        const int CARD_HEIGHT = 100;  // высота карты

        const int emptyCard = 53;   // индекс изображения пустой карты
        const int backCard = 52;    // индекс изображения рубашки карты
        const int empCard = 54;   // индекс изображения пустой колоды
        const int refreshCard = 55;

        private bool newgame ;

        private Undo undoList;

        private Card dragCard;      // перемещаемая карта
        private int dragX = 72, dragY = 220;   // координаты перемещаемой карты
        private int deltaX, deltaY; // разница между координатами перемещаемой карты и координатами курсора на ней 
        private int dragRow = 0;    // ряд, с которого перемещается карта 
        private int dragCol = 0;
        private int dropRow = -1;    // ряд, на который перемещается карта 
        private int dropCol = -1;

        private developers devop = new developers();
        private Rules rl = new Rules();
        private Graphics grf;

        private Pile KingBubi;
        private Pile KingTref;
        private Pile KingCherv;
        private Pile KingPika;
        private Pile ChervTyz;

        private Pile cards;
        private Pile talon;

        private Pile[,] PilesCenter;
        private Pile[,] Piles;

        private Deck deck;      // колода

        private bool drag;      // флаги выполнения drag & drop

        int kolvo =0;

        private void НоваяИгра(object sender, EventArgs e)
        {
            отменитьХодToolStripMenuItem.Enabled = false;
            dragCard = null;
            dragRow = 0;
            dragCol = 0;
            dropRow = 0;
            dropCol = 0;
            dragX = 0;
            dragY = 0;
            drag = false;

            newgame = false;
            grf = this.CreateGraphics();
            this.Refresh();

            deck = new Deck();
            deck.Shuffle();

            undoList = new Undo();

            Piles = new Pile[1, 6];
            PilesCenter = new Pile[3, 3];

            KingBubi = new Pile();
            KingTref = new Pile();
            KingCherv = new Pile();
            KingPika = new Pile();

            cards = new Pile();
            talon = new Pile();

            ChervTyz = new Pile();
            Card card = new Card(0, 0);

            int s = 1;
            kolvo = 0;
            newgame = true;
            
            for (int i = 0; i < 104; i++)
            {
                card = deck.GetCard();
                if (card.Rank == 12 && card.Suit == 0)
                {
                    KingTref.AddCard(card);
                }
                else if (card.Rank == 12 && card.Suit == 1)
                {
                    KingBubi.AddCard(card);
                }
                else if (card.Rank == 12 && card.Suit == 2)
                {
                    KingCherv.AddCard(card);
                }
                else if (card.Rank == 12 && card.Suit == 3)
                {
                    KingPika.AddCard(card);
                }
                else if (card.Rank == 0 && card.Suit == 2 && s == 1)
                {
                    ChervTyz.AddCard(card);
                    s = 0;
                } else
                {
                    cards.AddCard(card);
                }
            }

            int yy = 100;
            for (int i = 0; i < 3; i++)
            {
                int prob = 336;
                for (int j = 0; j < 3; j++)
                {
                    PilesCenter[i, j] = new Pile();

                    PilesCenter[i, j].X = prob + 88;
                    PilesCenter[i, j].Y = yy;
                    prob += 88;
                }
                yy += 120;
            }

            PilesCenter[0, 0].AddCard(KingBubi.GetCard());
            PilesCenter[0, 1].AddCard(ChervTyz.GetCard());
            PilesCenter[0, 2].AddCard(KingBubi.GetCard());

            PilesCenter[1, 0].AddCard(KingTref.GetCard());
            PilesCenter[1, 1].AddCard(KingCherv.GetCard());
            PilesCenter[1, 2].AddCard(KingTref.GetCard());

            PilesCenter[2, 0].AddCard(KingPika.GetCard());
            PilesCenter[2, 1].AddCard(KingCherv.GetCard());
            PilesCenter[2, 2].AddCard(KingPika.GetCard());

            int x = 72;
            int y = 220;

            for (int i = 0; i < 6; i++)
            {
                Piles[0, i] = new Pile();
                Piles[0, i].AddCard(cards.GetCard());
                if (i == 3)
                {
                    x += 352;
                }
                else
                {
                    x += 88;
                }
                Piles[0, i].X = x;
                Piles[0, i].Y = y;
            }

            cards.X = 952;
            cards.Y = 100;

            talon.X = 952;
            talon.Y = 220;

            if(newgame)
            {
            print(grf);
            }
        }

        private void print(Graphics g)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < PilesCenter[i, j].Count; k++)
                    {
                        imageList1.Draw(g, PilesCenter[i, j].X, PilesCenter[i, j].Y, PilesCenter[i, j][k].ImageIndex);
                    }
                }

            }
            for (int i = 0; i < 6; i++)
            {                
                imageList1.Draw(g, Piles[0, i].X, Piles[0, i].Y, emptyCard);   
            }
            imageList1.Draw(g, talon.X, talon.Y, emptyCard);


            for (int i = 0; i < 6; i++)
            {
                for (int k = 0; k < Piles[0, i].Count; k++)
                {
                    imageList1.Draw(g, Piles[0, i].X, Piles[0, i].Y, Piles[0, i][k].ImageIndex);
                }
            }
  

            if (cards.Count > 0)
            {
                imageList1.Draw(g, cards.X, cards.Y, backCard);
            } else if(kolvo == 3)
            {
                imageList1.Draw(g, cards.X, cards.Y, empCard);
            }
            else
            {
                imageList1.Draw(g, cards.X, cards.Y, refreshCard);
            }

            if (talon.Count > 0)
            {
                for(int i = 0; i < talon.Count; i++)
                {
                    imageList1.Draw(g,talon.X,talon.Y,talon[i].ImageIndex);
                }
            }

                if (drag)
            {
                imageList1.Draw(g, dragX, dragY, dragCard.ImageIndex);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (newgame)
                {
                if (DeckAction(e.X, e.Y))
                {
                    if (undoList.Count > 0) отменитьХодToolStripMenuItem.Enabled = true;
                    CardToTalon();
                }
                else 
                {
                    dragCard = CaptureCard(e.X, e.Y); // перемещаемая карта

                    if (dragCard != null)
                    {
                        deltaX = e.X - dragX;
                        deltaY = e.Y - dragY;
                        drag = true;
                    }
                }
            } 

                }

        }

        private Card CaptureCard(int x, int y) // возвращает карту которую мы захватываем
        {
            Card card = null;

            for (int col = 0; col < 6; col++)
            {
                if (x >= Piles[0, col].X && x <= Piles[0, col].X + CARD_WIDTH && y <= Piles[0, col].Y + CARD_HEIGHT && y >= Piles[0, col].Y)
                {
                    dragCol = col;
                    for (int row = 0; row < 1; row++)
                    {
                        if (Piles[row, col].Count > 0)
                        {

                            dragRow = row;

                            dragX = Piles[row, col].X;
                            dragY = Piles[row, col].Y;

                            card = Piles[row, col].GetCard();

                            return card;

                        }
                    }
                }
                else if (x >= talon.X && x <= talon.X+CARD_WIDTH && y >= talon.Y && y <= talon.Y + CARD_HEIGHT )
                {
                    dragX = talon.X;
                    dragY = talon.Y;

                    dragCol = -1;
                    dragRow = -1;

                    card = talon.GetCard();
                    return card;
                }
            }


            return card;
        }//ready
        private bool CanDrop(int x, int y)     //проверяем возможность перемещения карты в данную позицию
        {
            Card card;
            Card card2 = dragCard;
            if (drag)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (PilesCenter[i, j].Count > 0)
                        {                       
                            card = PilesCenter[i, j][PilesCenter[i, j].Count - 1];

                            if (Intersected(x, y, PilesCenter[i, j].X, PilesCenter[i, j].Y))
                            {
                                dropRow = i;
                                dropCol = j;

                                if ((card.Rank == 12) && (card2.Rank == 0) && (card.Suit == card2.Suit))
                                {
                                    if (i==1 && j == 1)
                                    {
                                        return false;
                                    }
                                    return true;
                                } else if ((card.Rank + 1 == card2.Rank) && (card.Suit == card2.Suit)) 
                                {
                                    if (i == 1 && j == 1)
                                    {
                                        return false;
                                    }
                                    return true;
                                }

                            }                         
                   
                        }
                    }
                }
            }
            return false;
        }//ready

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                if (CanDrop(dragX, dragY))
                {
                     if(dropCol == -1 && dropRow == -1)                     //
                    {                                                      //
                        talon.AddCard(dragCard);                           //         
                    }                                                      //
                    else                                                   //
                    {                                                      //
                        PilesCenter[dropRow, dropCol].AddCard(dragCard);  // перемещаем на новое место                        
                    }
 
                    if ( dragCol == -1 && dragRow == -1)
                    {
                         undoList.Save(talon, PilesCenter[dropRow, dropCol]);
                    }
                    else
                    {                  
                        undoList.Save(Piles[dragRow, dragCol], PilesCenter[dropRow, dropCol]);  // сохраняем ход для истории
                    }
                    Table();                                               //заполняем пустые ячейки на столе(кроме талона)
                    отменитьХодToolStripMenuItem.Enabled = true;

                }
                else
                {
                    if (dragRow == -1 && dragCol == -1 )
                    {
                        talon.AddCard(dragCard);
                    }
                    else
                    {
                        Piles[dragRow, dragCol].AddCard(dragCard);  // возвращаем на старое место
                    }
                }
            }
            if(newgame)
            {
            print(grf);
            if (IsVictory()) MessageBox.Show("Вы выиграли!", "Пасьянс Пирамида Султана");
            }
            dragCard = null;
            dragRow = 0;
            dragCol = 0;
            dropRow = 0;
            dropCol = 0;
            dragX = 0;
            dragY = 0;
            drag = false;

        }

        private bool IsVictory()
        {
            bool mb = false;
            for (int i = 0; i < 6; i++)
            {
                if (Piles[0, i].Count == 0)
                {
                    mb = true;
                } else
                {
                    mb = false;
                    break;
                }
            }

            if (mb && cards.Count == 0 && talon.Count == 0)
            {
                newgame = false;
                return true;
            }
            else return false;
        }//ready
 
        private void Table()
        {
            if (talon.Count > 0 && dragCol != -1 && dragRow != -1)
            {
                Piles[dragRow, dragCol].AddCard(talon.GetCard());
                undoList.Save(talon, Piles[dragRow,dragCol]);
            } else if(cards.Count > 0 && dragCol != -1 && dragRow != -1)
            {
                Piles[dragRow, dragCol].AddCard(cards.GetCard());
                undoList.Save(cards,Piles[dragRow, dragCol] );
            }
        }
        private bool DeckAction(int x, int y)
        {
            // Проверка попадания курсора на колоду
            if (x >= cards.X && x <=cards.X + CARD_WIDTH && y >= cards.Y && y <= cards.Y + CARD_HEIGHT && cards.Count > 0)
            {
                return true;
            }
            else if (x >= cards.X && x <= cards.X + CARD_WIDTH && y >= cards.Y && y <= cards.Y + CARD_HEIGHT)
            {
                FromTalonToCards();
                return false;
            }
            return false;
        }//ready

        private void FromTalonToCards()
        {

            int g = talon.Count;
            if (kolvo < 3 && cards.Count == 0)
            {
                for (int i = 0; i < g; i++)
                {
                    cards.AddCard(talon.GetCard());
                }
                kolvo++;
            }
        
        }
        private void CardToTalon(){             
            talon.AddCard(cards.GetCard());
            undoList.Save(cards, talon);
        }//ready

        private bool Intersected(int x1, int y1, int x2, int y2)
    {
        if (((x2 <= x1 && x1 <= x2 + CARD_WIDTH) || (x1 <= x2 && x2 <= x1 + CARD_WIDTH)) &&
           ((y2 <= y1 && y1 <= y2 + CARD_HEIGHT) || (y1 <= y2 && y2 <= y1 + CARD_HEIGHT)))
        {
            return true;
        }
        return false;
    }//ready
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                dragX = e.X - deltaX;
                dragY = e.Y - deltaY;
            }
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (newgame) print(e.Graphics);
        }
        public Пасьянс_Горем_Султана()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void dev(object sender, EventArgs e)
        {
            devop.ShowDialog();
        }
        private void takerules(object sender, EventArgs e)
        {
            rl.ShowDialog();
        }
        private void Выход(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void отменитьХодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undoList[undoList.Count-1].From != deck)
            {
                undoList.Restore();
            }
            else
            {
                while (undoList.Count > 0 && undoList[undoList.Count-1].From == deck)
                {
                    undoList.Restore();
                }
            }

            bool ds = true;
            if (cards.Count == 0 && talon.Count == 0) ds = false;
            for(int i = 0; i < 6; i++)
            {
                if (Piles[0,i].Count == 0 && ds)
                {
                    undoList.Restore();
                }
            }

            if (undoList.Count == 0) отменитьХодToolStripMenuItem.Enabled = false;
            this.Invalidate();
        }
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
    

    

    
