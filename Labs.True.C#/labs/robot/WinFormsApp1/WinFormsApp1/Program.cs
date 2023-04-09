using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using библиотекаћетодов–оботаЌа—труктуреѕоле;
using библиотека‘ормировани€—ред;
 


namespace WinFormsApp1
{
    static class Program
    {
         
        static ситуаци€Ќаѕоле поле;
        static инфо–обот робот;
        static построитель—реды построитель = new построитель—реды();

        [STAThread]
        static void Main()
        { 

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            поле = построитель.построитель—реды–обота("if", 3);
          
            Application.Run(new среда–обота(поле));
            робот = new инфо–обот(поле);

              
            –ешение«адачи3();
            поле = робот.результат–аботы;
            Application.Run(new среда–обота(поле));

        }
        static void –ешение«адачи3()
        {
            int k = 0;

            робот.влево();
            if (робот.сверху—вободно && робот.снизу—вободно)
            {
                робот.вправо();
                робот.вправо();
                k = 1;
            }


            if (k == 0)
            {   
                while (робот.сверху—тена && робот.снизу—тена)
                {
                    if(робот.радиаци€ > 0)
                    {
                        if (робот.клетка«акрашена)
                        {
                            continue;
                        }
                               
                        func();
                    }
                    робот.влево();

                }
            }
            else
            {
                while (робот.сверху—тена && робот.снизу—тена)
                {
                    if (робот.радиаци€ > 0)
                    {
                        if (робот.клетка«акрашена)
                        {
                            continue;
                        }
                         
                        func();
                    }
                    робот.вправо();

                }
            }
            
            робот.кончить–аботу("Inlet.in");
            }
        static void func()
        {
            робот.влево();
 
             while (true)
            {
                if (робот.клетка«акрашена)
                {
                    break;
                }
                else
                {
                    if (робот.радиаци€ == 0)
                    {
                        робот.закрасить();
                    }
                    break;
                }
            }
             
            робот.вправо();
            робот.вправо();

            while (true)
            {
                if (робот.клетка«акрашена)
                {
                    break;
                }
                else
                {
                    if (робот.радиаци€ == 0)
                    {
                        робот.закрасить();
                    }
                    break;
                }
            }


            робот.влево();
        }
    }

  
    }

