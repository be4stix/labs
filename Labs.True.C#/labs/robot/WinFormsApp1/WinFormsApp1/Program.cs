using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ��������������������������������������;
using ��������������������������;
 


namespace WinFormsApp1
{
    static class Program
    {
         
        static �������������� ����;
        static ��������� �����;
        static ���������������� ����������� = new ����������������();

        [STAThread]
        static void Main()
        { 

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ���� = �����������.����������������������("if", 3);
          
            Application.Run(new �����������(����));
            ����� = new ���������(����);

              
            �������������3();
            ���� = �����.���������������;
            Application.Run(new �����������(����));

        }
        static void �������������3()
        {
            int k = 0;

            �����.�����();
            if (�����.�������������� && �����.�������������)
            {
                �����.������();
                �����.������();
                k = 1;
            }


            if (k == 0)
            {   
                while (�����.����������� && �����.����������)
                {
                    if(�����.�������� > 0)
                    {
                        if (�����.���������������)
                        {
                            continue;
                        }
                               
                        func();
                    }
                    �����.�����();

                }
            }
            else
            {
                while (�����.����������� && �����.����������)
                {
                    if (�����.�������� > 0)
                    {
                        if (�����.���������������)
                        {
                            continue;
                        }
                         
                        func();
                    }
                    �����.������();

                }
            }
            
            �����.�������������("Inlet.in");
            }
        static void func()
        {
            �����.�����();
 
             while (true)
            {
                if (�����.���������������)
                {
                    break;
                }
                else
                {
                    if (�����.�������� == 0)
                    {
                        �����.���������();
                    }
                    break;
                }
            }
             
            �����.������();
            �����.������();

            while (true)
            {
                if (�����.���������������)
                {
                    break;
                }
                else
                {
                    if (�����.�������� == 0)
                    {
                        �����.���������();
                    }
                    break;
                }
            }


            �����.�����();
        }
    }

  
    }

