
namespace InterfacesAndAbstractClasses
{
    //Add order related methods to interface so all meals that implement will have same methods
    //Better here because order functionality can be applied to any meal or potential deserts and appetizers
    //Should change to accept and return a seperate order object or generic
    interface IOrder
    {
        MealDeal GetOrder(string optionOne, string optionTwo);
        void PrintOrder(MealDeal meal);
    }
}
