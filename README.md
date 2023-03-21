# **GeometricFigureLibrary**
Библиотека определяет типы геометрических фигур, а также содержит методы вычисления площади фигуры без указания ее типа.

## Использование

Создадим экземпляр объекта типа Triangle

![image](https://user-images.githubusercontent.com/55708187/226636296-d234437c-4ddc-469c-8a80-aa9fa9fa1e0c.png)

Подключим пространство имен GeometricFigure.Interfaces

![image](https://user-images.githubusercontent.com/55708187/226646927-e56829d1-7555-4e9a-b26e-ecfc5603b88c.png)

Инициализируем переменную geometricFigure типа IGeometricFigure и присвоим ей ссылку на вышесозданный объект треугольника

![image](https://user-images.githubusercontent.com/55708187/226637015-f3bbd86d-d315-4c26-b9c7-12363cb64474.png)

Для вычисления площади фигуры обратимся к методу GetArea

![image](https://user-images.githubusercontent.com/55708187/226641142-59899900-dc7d-451c-a0b9-7d114a0706cf.png)

В случае с типом треугольника предусмотрена проверка на прямоугольный треугольник. Для этого необходимо обратиться к свойству IsRightTriangle объекта triangle

![image](https://user-images.githubusercontent.com/55708187/226644921-2a2f6502-93dd-4a13-9223-29da92c5adf8.png)
