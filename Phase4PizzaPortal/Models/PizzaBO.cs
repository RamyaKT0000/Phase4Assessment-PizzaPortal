using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phase4PizzaPortal.Models
{
    public class PizzaBO
    {
        public static List<PizzaModel> pizza;
        public PizzaBO()
        {
            pizza = new List<PizzaModel>
            {
                new PizzaModel{
                    PId = 1,
                    PName = "Margherita",
                    PCrustSize = "Small",
                    PDesc = "A hugely popular margherita, with a deliciously tangy single cheese topping",
                    PPrice = 75,
                    PImage = "https://i2.wp.com/www.vegrecipesofindia.com/wp-content/uploads/2020/12/margherita-pizza-4.jpg"
                },

                new PizzaModel{
                    PId = 2,
                    PName = "Double Cheese Margherita",
                    PCrustSize = "Medium",
                    PDesc = "The ever-popular margherita- loaded with extra cheese oodies of it",
                    PPrice = 110,
                    PImage = "https://tse1.mm.bing.net/th/id/OIP.HSuLEHkqf0pGEmsqLPdIDgHaKE?pid=ImgDet&rs=1"
                },

                new PizzaModel{
                    PId = 3,
                    PName = "Farm House",
                    PCrustSize = "Large",
                    PDesc = "A pizza that goes ballistic on veggies! check out this mouth watering overload of crunchy, crisp capsicum, succulent mushrooms and fresh tomatoes",
                    PPrice = 125,
                    PImage = "https://th.bing.com/th/id/R.6a2397dc47a5e64fa992efdba1629ff3?rik=dFfGlDvOSU5Gog&riu=http%3a%2f%2f3.bp.blogspot.com%2f-GEdhjxzjzVs%2fUpD3OFVvl8I%2fAAAAAAAAAQI%2fZlVGqNDCvIM%2fs1600%2fRecipe-of-farmhouse-pizza-food-factory.jpg&ehk=5AQn5%2f2%2bb1dDrmxojmUaA45iWzFJ%2bjo%2b4nE0yW86mlE%3d&risl=&pid=ImgRaw&r=0"
                },

                new PizzaModel{
                    PId = 4,
                    PName = "Peppy Paneer",
                    PCrustSize = "Extra Large",
                    PDesc = "Chunky paneer with crisp capsisum and spicy red pepper- quite a mouthful!",
                    PPrice = 175,
                    PImage = "https://s3-eu-west-1.amazonaws.com/cdn.nordic-wewalka/ww-pizza_spinat_1742.jpg"
                },

                new PizzaModel{
                    PId = 5,
                    PName = "Mexican GreenWave",
                    PCrustSize = "Extra Large",
                    PDesc = "A pizza loaded with crunchy onions, crisp capsicums, juicy tomatoes and jalapeno with a liberal sprinkling of exotic mexican herbs",
                    PPrice = 175,
                    PImage = "https://cdn.shopify.com/s/files/1/0808/5563/products/061219_Pepperoni_Full_1200x1200.jpg?v=1560820716"
                },

                new PizzaModel{
                    PId = 6,
                    PName = "Delux Veggie",
                    PCrustSize = "Large",
                    PDesc = "For a vegetarian looking for a big treat that goes easy on spices, this one's goes it all. The onions, the capsicum, those delectable mushrooms- with paneer and golden corn to top it all",
                    PPrice = 135,
                    PImage = "https://tse1.mm.bing.net/th/id/OIP.Mu_qclDo5gWcrPcId1m_IwHaHa?pid=ImgDet&rs=1"
                },

                new PizzaModel{
                    PId = 7,
                    PName = "Veg Extravaganza",
                    PCrustSize = "Medium",
                    PDesc = "A pizza that decidedly straggers under an overload of golden corn, exotic black olives, crunchy onions, crisp capsicum, succulent mushrooms, juicy fresh tomatoes and jalapeno- with extra cheese to go all around",
                    PPrice = 110,
                    PImage = "https://tse1.mm.bing.net/th/id/OIP.f4KsUS1N-qtIPyB6NS3L5QHaEo?pid=ImgDet&rs=1"
                },

                new PizzaModel{
                    PId = 8,
                    PName = "Cheese n corn",
                    PCrustSize = "Small",
                    PDesc = "Cheese I golden corn",
                    PPrice = 90,
                    PImage = "https://tse4.mm.bing.net/th/id/OIP.D3HFxRIoiAPr8oE0sc_AbAHaHa?pid=ImgDet&rs=1"
                }

            };
        }

        public List<PizzaModel> GetAllPizzas()
        {
            return pizza;
        }

        public PizzaModel GetPizzaById(int id)
        {
            return pizza.Find(p => p.PId == id);
        }
    }
}
