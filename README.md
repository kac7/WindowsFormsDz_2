# WindowsFormsDz_2
<h1>Задание 6</h1>
Написать программу, которая по введенной дате определяет день недели. Результат выводить в текстовое поле (желательно по-русски). 

<h1>Задание 7</h1>
Написать программу, вычисляющую сколько осталось времени до указанной даты (дата вводится с клавиатуры в Edit). Предусмотреть возможность выдачи результата в годах, месяцах, днях, минутах, секундах (для первых двух вариантов ответ дробный). Для переключения между вариантами желательно использовать переключатели (RadioButton).

<h1>Задание 8</h1>
Постановка задачи:<br>
Владелец автозаправки «BestOil» заказал следующую программу. Когда автозаправка только начинает свою деятельность, владелец обычно хочет получать максимально большой доход, который планирует увеличить за счет дополнительных услуг. Поэтому на автозаправке будет действовать небольшое кафе. Но, в то же время он может нанять только одного работника на должность кассира, а потому назначение программы – учет продаж бензина и ассортимента товаров в миникафе.<br>
Требования к поставленной задаче:<br>
Для удобства окно разделено на три части: <br>
первая для осуществления вычислений, касающихся непосредственно заправки автомобилей топливом; <br>
вторая – покупки в мини-кафе; <br>
третья часть для вычисления суммы оплаты. <br>
Итак, первая группа элементов Автозаправка. ComboBox – выпадающий список с перечнем имеющегося горючего. По умолчанию, сразу при запуске программы должен быть выбран определенный вид горючего и в TextBox (или например Label) должна отображаться цена на данный вид продукта. При каждой смене выбора бензина, цена в данном поле будет соответственно меняться. Далее, дается возможность выбора: купить горючее, указав необходимое количество литров или указав, на какую сумму клиент будет заправляться. При этом, после выбора одного из двух вариантов предоставления услуги, ненужное поле становится заблокированным. В случае ввода суммы денег, группа «К оплате» изменит название на «К выдаче»; вместо суммы следует выводить количество литров, соответственно изменяются единицы измерения с «грн..» на «л»..Вторая группа Мини-кафе. Для удобства, все возможные товары выведены сразу в данной части. Для каждого продукта предусмотрены CheckBox с названием товара, рядом выводится цена (неактивный TextBox). При получении заказа для возможности ввода количества заказанных единиц товара, следует поставить «галочку» в CheckBox напротив соответствующего товара. Последняя – «К оплате». Содержит кнопку, которая отвечает за осуществление вычисления и вывода сумм в соответствующих полях. После того, как выведена сумма, через (например) 10 секунд должен появиться запрос на очистку формы, то есть при появлении следующего клиент: да – все поля принимают значения по умолчанию, нет – неизменное состояние остается еще на 10 секунд. При выходе из программы (закончился рабочий день) должно появиться окно с сообщением, какова общая сумма выручки за данный день. Или эту сумму можно сразу выводить в самой форме и изменять после каждого осуществления расчета с клиентом. Кроме этого, придайте форме эстетический вид (цвета, шрифты, рисунки ...).<br>
При обоснованной необходимости и интересном решении функциональности программы разрешается вносить изменения во внешний вид формы или набор элементов.
