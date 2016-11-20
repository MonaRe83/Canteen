using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenFoodOrdering
{
    class DeliveryInfo
    {
        public int updateID;
        public string name;
        public string address;
        public string mobileNo;

        public DeliveryInfo(int up, string nam, string add, string mobNo)
        {
            // TODO: Complete member initialization
            this.updateID = up;
            this.name = nam;
            this.address = add;
            this.mobileNo = mobNo;
        }

      /// <summary>
      /// lkljkjkj
      /// </summary>
        public int upid
        {
            get { return updateID; }
            set { updateID = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string nam
        {
            get { return name; }
            set { name = value; }
        }

        public string add
        {
            get { return address; }
            set { address = value; }
        }

        public string mobNo
        {
            get { return mobileNo; }
            set { mobileNo = value; }
        }
   }




}
