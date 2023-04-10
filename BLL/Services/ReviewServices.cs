using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.Entities;
using DAL.EF;

namespace BLL.Services
{
    public class ReviewServices
    {
        public static List<ReviewModel> Get()
        {
            var data = DataAccessFactory.GetReviewAccess().Get();
            var d = new List<ReviewModel>();
            foreach (var s in data)
            {
                d.Add(new ReviewModel()
                {
                   review_id = s.review_id,
                   comment = s.comment,
                   review_date = s.review_date,
                   customer_id = s.customer_id,
                    

                });

            }
            return d;

        }

        public static ReviewModel Get(int id)
        {
            var s = DataAccessFactory.GetReviewAccess().Get(id);
            var d = new ReviewModel()
            {
                review_id = s.review_id,
                comment = s.comment,
                review_date = s.review_date,
                customer_id = s.customer_id,
            };
            return d;

        }
        public static bool Delete(int id)
        {

            return DataAccessFactory.GetReviewAccess().Delete(id);

        }
        public static bool Create(ReviewModel s)
        {
            var c = new review()
            {
                review_id = s.review_id,
                comment = s.comment,
                review_date = s.review_date,
                customer_id = s.customer_id,

            };
            return DataAccessFactory.GetReviewAccess().Create(c);
        }
        public static bool Update(ReviewModel s)
        {

            var d = new review()
            {
                review_id = s.review_id,
                comment = s.comment,
                review_date = s.review_date,
                customer_id = s.customer_id,

            };
            return DataAccessFactory.GetReviewAccess().Update(d);

        }
    }
}
