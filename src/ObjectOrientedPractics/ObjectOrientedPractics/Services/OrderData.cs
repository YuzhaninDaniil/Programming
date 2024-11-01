using ObjectOrientedPractics;
using System.ComponentModel;

namespace ObjectOrientedPractices
{
    /// <summary>
    /// Хранит данные о заказе для заполнения таблицы
    /// </summary>
    public class OrderData
    {
        /// <summary>
        /// Id заказа
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// ФИ покупателя
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Адрес доставки 
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Общая стоимость
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// Статус заказа
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Заказ с товаром
        /// </summary>
        [Browsable(false)]
        public Order Order { get; set; }
    }
}
