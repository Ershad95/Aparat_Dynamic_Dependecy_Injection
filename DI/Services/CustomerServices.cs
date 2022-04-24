using WebApplication2.Services.Interface;

namespace WebApplication2.Services
{
    public class CustomerServices : InfoBase,ICustomerServices
    {

        public int OK() => 0;
        public string GetCustomerId() => "10";

        public  (int, int) GetAllInfo(params int[] ints)
        {
            object ok() => true;
            object nok() => false;


            foreach (var item in ints)
            {
                
            }

            _ = 10 > 5 ? ok() : nok();
            return (10, 10);
        }
    }
    public abstract class Info
    {
        public abstract int Id();

        public virtual (int,int) GetAllInfo()
        {
            return (10, 20);
        }
    }
    public abstract class InfoBase
    {
        
        public virtual int OK(params int[] numbers)
        {

            return 0;
        }
    }



}
