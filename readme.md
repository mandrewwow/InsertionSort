# Реализация сортировки "Сортировка вставками"
Эта программа представляет собой наглядную реализацию алгоритма сортировки вставками. 
На каждом шаге алгоритма мы выбираем один из элементов входных данных и вставляем его
на нужную позицию в уже отсортированном списке до тех пор, пока набор входных данных 
не будет исчерпан. Метод выбора очередного элемента из исходного массива произволен; 
может использоваться практически любой алгоритм выбора. Обычно (и с целью получения 
устойчивого алгоритма сортировки), элементы вставляются по порядку их появления во 
входном массиве.
Три составные части:

- Блок InserionSort, в котором находится класс InsertionSorter с реализацией алгоритма,
метод public void InsSort(int[] mass) получает массив целых чисел и сортирует их в порядке
возрастания значений. 
- Блок InsertionSort.Usage, в котором демонстрируется использование алгоритма путем вывода через консоль.
- Блок ShakerSort.Tests, в котором находятся тесты: сортировка массива из нулей, сортировка пустого массива,
сортировка массива с отрицательными элементами, сортировка обычного массива, сортировка массива из 
одного элемента.

Класс InsertSort работает только c массивами целочисленного типа(int[]).

Исключение ArgumentNullException срабатывает, если полученный массив имел значение null.

Лицензия проекта - GNU GPL, следовательно, он может использоваться для любых целей.
