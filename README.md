# Задача: "Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Описание решения:

1. Созадаем массив строк stringArray с элементами массива типа string. В качестве длины массива задается любое произвольное значение.

2. Создаем массив newArray[stringArray.Length], длина которого равна длине массива stringArray для того, что бы если все элементы массива stringArray окажутся < = 3, они бы уместились в массиве newArray.

3. Сoздаем переменную int j = 0 - индекс элементов массива newArray.

4. Создаем переменную int size = 3, с которой будем сравнивать количество символов строк.

5. Создаем цикл for, выходом из которого будет являтся анализ длины каждого элемента массива stringArray. Цикл позволяет последовательно взять каждый элемент массива stringArray для определения длины данного элемента. 

6. Внутри цикла for создаем условный оператор if, который сравнивает каждый элемент массива stringArray с size. Если сравнение соответствует условию задачи, то значению newArray[j] присваивается значение stringArray[i]. Переменную j увеличиваем на 1, что бы перейти к заполнению следующего элемента массива newArray. После завершения цикла for, мы имеем массив newArray с элементами, соответствующими условиям задачи. 

7. Выводим массив newArray на экран с помощью команды Console.Write.