using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BusinessLayer
{
    public class Item
    {
        internal Item() { }

        internal int _itemId;
        internal string _itemName;
        internal string _description;
        internal int _quantity;
        internal double _price;
        internal string _location;
        internal string _justification;
        internal ItemStatus _itemStatus;
        internal int _orderNumber;

        public int ItemId
        {
            get
            {
                return _itemId;
            }
            set
            {
                if (_itemId == value)
                {
                    return;
                }
                _itemId = value;
            }
        }

        public string ItemName
        {
            get
            {
                return _itemName;
            }
            set
            {
                if (_itemName == value)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Item Name cannot be null or empty");
                }
                if (!Validate.ValidateLength(value, 30))
                {
                    throw new ArgumentException("Item Name must be 30 characters or less");
                }
                if (!Validate.ValidateName(value))
                {
                    throw new ArgumentException("Item Name is not valid");
                }
                _itemName = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (_description == value)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Description cannot be null or empty");
                }
                if (!Validate.ValidateLength(value, 255))
                {
                    throw new ArgumentException("Description must be 255 characters or less");
                }
                if (!Validate.ValidateName(value))
                {
                    throw new ArgumentException("Description is not valid");
                }
                _description = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (_price == value)
                {
                    return;
                }
                _price = value;
            }
        }

        public string Location
        {
            get
            {
                return _location;
            }
            set
            {
                if (_location == value)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Location cannot be null or empty");
                }
                if (!Validate.ValidateLength(value, 50))
                {
                    throw new ArgumentException("Location must be 50 characters or less");
                }
                if (!Validate.ValidateName(value))
                {
                    throw new ArgumentException("Location is not valid");
                }
                _location = value;
            }
        }

        public string Jusitification
        {
            get
            {
                return _justification;
            }
            set
            {
                if (_justification == value)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Jusitification cannot be null or empty");
                }
                if (!Validate.ValidateLength(value, 255))
                {
                    throw new ArgumentException("Jusitification must be 255 characters or less");
                }
                if (!Validate.ValidateName(value))
                {
                    throw new ArgumentException("Jusitification is not valid");
                }
                _justification = value;
            }
        }

        public ItemStatus ItemStatus
        {
            get
            {
                return _itemStatus;
            }
            set
            {
                if (_itemStatus == value)
                {
                    return;
                }
                _itemStatus = value;
            }
        }

        public int OrderNumber
        {
            get
            {
                return _orderNumber;
            }
            set
            {
                if (_orderNumber == value)
                {
                    return;
                }
                _orderNumber = value;
            }
        }
    }
}
