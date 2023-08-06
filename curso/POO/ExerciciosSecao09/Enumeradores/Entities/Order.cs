
using curso.POO.ExerciciosSecao09.Enumeradores.Enums;

namespace curso.POO.ExerciciosSecao09.Enumeradores.Entities;

internal class Order
{
    public int Id { get; set; }
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, \nDate and time: {Moment}, \nSituation: {Status}";
        //return Id
        //    + ", "
        //    + Moment
        //    + ", "
        //    + Status;
    }
}
