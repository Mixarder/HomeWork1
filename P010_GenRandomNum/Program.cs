//Генератор псевдослучайных чисел

int numberA = new Random ().Next(1,10);
//целая переменная numberA сгенерирована Генератором new Random().Next() - в скобках next указываем диапазон генерации чисел

Console.WriteLine(numberA);  //Результат генирации выводится на экран

int numberB = new Random ().Next(1,10); // Генерируется вторая переменная NumberB

Console.WriteLine(numberB); // Результат выводится на экран

int Result = numberA + numberB; //производим сложение двух сгенерированных числел с записью в контейнер Result

Console.WriteLine(Result); //Выводим на экран содержание контейнера Result

