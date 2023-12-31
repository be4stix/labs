﻿using System;
using System.Windows.Forms;
using библиотекаИсполнителяПутник;

namespace исполнительПутник_v_2
{
    public class решениеЗадачи
    {
        Путник путник;
        гаммаЦветов цветЗакраски = гаммаЦветов.желтый;

        public решениеЗадачи()
        {
            // Инициализация сгенерированной обстановки
            путник = new Путник("Inlet.in");
            try
            {
                int l = 0;
                путник.повернутьсяНалево();
                путник.сделатьШаг();
                путник.повернутьсяНалево();

                while (путник.впередиСвободно)
                {
                    путник.сделатьШаг();
                    zakracit();
                }
                
      
                    

                void zakracit()
                {
                    
                }
            }
                catch (Exception сообщение)
                {
                    //***********************************************************************************
                    // Замечание:  Сообщения выводятся только при условии указания темы и номера задачи *
                    //***********************************************************************************
                    MessageBox.Show(сообщение.Message, "Причина ошибки");
                    MessageBox.Show(путник.ToString(), "Место Путника в период ошибки");
            }
        }
    } 
}

