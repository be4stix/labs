﻿using System;
using System.IO;

namespace построениеКлассаВектор_задача01
{
    /*      
     *  Построить класс вектор элементов со значениями элементов, указанного в условии задачи типа.
     *  Предусмотреть инициализацию вектора (конструкторы)
     *    -	значениями по умолчанию;
     *    -	значениеми, передаваемыми входным параметром;
     *    -	значениями, указанными соответствующим вариантом задания (из файла Inlet.in с учетом 
     *    указанных в условии задачи особенностями).
     *    
     *  В данном классе предусмотреть реализацию методов, указанных в условии задачи связанных с
     *    -	метод расчета максимально допустимой степени числа С;
     *    -	метод построения массива степеней числа С - индексов извлекаемых из исходного объекта значений;
     *    -	метод построения нового объекта "Вектор" В (см. условие задачи);
     *    -	метод увеличения компонент исходного объекта в С раз.
     */
    public class Вектор
    {
        private int[] вектор;
        private Random случайноеЧисло = new Random();
        private int C = 1, мощностьВ;                    

        /// <summary>
        /// Конструктор - по-умолчанию. Инициализация размерности вектора (100)
        /// </summary>
        public Вектор()
        {
            вектор = new int[100];
        }
        /// <summary>
        /// Конструктор - инициализация вектора заданной мощности
        /// </summary>
        /// <param name="мощность"> -  значение размерности вектора</param>
        public Вектор(int мощность)
        {
            вектор = new int[мощность];
        }
        /// <summary>
        /// Конструктор - инициализация вектора начальными значениями
        /// </summary>
        /// <param name="вектор"> - вектор-оригинал с исходными значениями</param>
        public Вектор(params int[] вектор)
        {
            this.вектор = new int[вектор.Length];
            for (int i = 0; i < вектор.Length; i++)
            {
                this.вектор[i] = вектор[i];
            }
            C = (int)Math.Ceiling(Math.Sqrt(вектор.Length));
        }
        /// <summary>
        /// Конструктор инициализации данных задачи, согласно варианту задания
        /// </summary>
        /// <param name="имяФайла">-имя файла инициализирующей информации с возможным указанием пути к нему</param>
        public Вектор(string имяФайла)
        {
            StreamReader файлВВ = new StreamReader(имяФайла);
            char[] разделители = { '\n', '\r', ' '};
            string[] элементыФайла = файлВВ.ReadToEnd().Split(разделители, System.StringSplitOptions.RemoveEmptyEntries);
            if (элементыФайла.Length != 0)
            { // По крайней мере С - имеется
                C = int.Parse(элементыФайла[0]);
                if (C >= 0)                
                {
                    if (элементыФайла.Length > 1)
                    { // Вектор не пуст - его элементы можно считать
                        вектор = new int[элементыФайла.Length - 1];
                        for (int i = 0; i < вектор.Length; i++)
                        {
                            вектор[i] = int.Parse(элементыФайла[i + 1]);
                        }                        
                    }
                    else
                    {
                        throw new Exception("Вектор пуст - поле данных <<вектор>> останется неопределенным");
                    }
                    
                }
                else
                {
                    throw new Exception("C - меньше нуля, а отрицательных индексов в массиве в C# нет");
                }
            }
            else
            {
                throw new Exception("Входной файл пуст!!!");
            }            
        }
        /// <summary>
        /// Индексатор с контролем за допустиростью значения индекса
        /// </summary>
        /// <param name="индекс"> - индекс элемента вектора</param>
        /// <returns></returns>
        ///         
        public int this[int индекс]
        {
            get
            {
                if (индекс >= 0 && индекс < вектор.Length)
                    return вектор[индекс];
                else
                    throw new Exception("Индекс - вне границ [ 0, " + (вектор.Length - 1) + " ]");
            }
            set
            {
                if (индекс >= 0 && индекс < вектор.Length)
                    вектор[индекс] = value;
                else
                    throw new Exception("Индекс " + индекс + " вне границ [ 0, " + (вектор.Length - 1) + " ]");
            }
        }
        /// <summary>
        /// Свойство опеределения мощности объекта
        /// </summary>
        public int мощностьОбъекта
        {
            get
            {
                return вектор.Length;
            }
        }
        /// <summary>
        /// Свойство-расчет верхней границы степени С  
        /// </summary>
        public int верхняяГраницаСтепенейС 
        {
            get
            {
                if (C > 1)
                {
                    int степеньС = 1;
                    мощностьВ = 0;
                    while (степеньС < мощностьОбъекта)
                    {
                        степеньС *= C;
                        мощностьВ++;
                    }
                    return степеньС / C;
                }
                else
                {
                    мощностьВ = 1;
                    return 1;
                }
                
            }
        }
        /// <summary>
        /// Метод формирования массива индексов, значения которых представляют
        /// степени числа С (первого поля данных текущего объекта) с таким расчетом,
        /// чтобы значение последнего индекса не выходило за пределы размерности
        /// данного объекта
        /// </summary>
        /// <returns>- массив значений индексов (степеней числа С)</returns>
        public int[] массивИндексовКопируемыхЭлементов()
        {
            int[] массивИндексов = new int[мощностьВ];
            int индекс = 1;
            for (int i = 0; i < мощностьВ; i++)
            {
                массивИндексов[i] = индекс;
                индекс *= C;
            }
            return массивИндексов;
        }
        /// <summary>
        /// Метод построения нового объекта на основе данного извлечением
        /// элементов с индексами данного объекта, значения которых передаются 
        /// через параметр
        /// Примечание: индексы "сдвинуты" на единицу к началу массива данного объекта
        /// </summary>
        /// <param name="индекс">- массив индексов извлекаемых элементов данного объекта</param>
        /// <returns>вектор-результат</returns>
        public Вектор построениеВектора(int[] индекс)
        {
            int[] результирующийВектор = new int[индекс.Length];
            for (int i = 0; i < мощностьВ; i++)
            {
                результирующийВектор[i] = вектор[индекс[i]-1];
            }
            return new Вектор(результирующийВектор);
        }
        /// <summary>
        /// Метод преобразования состояния объекта
        /// (в данном случае все компоненты вектора данных изменяются в С раз)
        /// </summary>
        public void преобразованиеОбъекта()
        {
            for (int i = 0; i < мощностьОбъекта; i++)
            {
                вектор[i] *= C;
            }
        }
        /// <summary>
        /// Метод вывода на консоль параметров (полей данных) объекта
        /// </summary>
        public void выводИнформации()
        {
            Console.WriteLine("C = {0}", C);
            for (int i = 0; i < мощностьОбъекта-1; i++)
            {
                Console.Write("{0} ", вектор[i]);
            }
            Console.WriteLine("{0}", вектор[мощностьОбъекта - 1]);
        }
    }
}
