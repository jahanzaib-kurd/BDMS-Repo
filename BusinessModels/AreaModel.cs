namespace BusinessModels
{
    using System;
    using System.ComponentModel;

    public class AreaModel : INotifyPropertyChanged, IDataErrorInfo
    {
        #region PrivateProperties
        private string areaId;
        private string areaCode;
        private string areaName;
        private bool? isDeleted;
        #endregion

        #region Public Properties
        public String AreaId
        {
            get { return areaId; }
            set { areaId = value; }
        }

        public String AreaCode
        {
            get { return areaCode; }
            set
            {
                areaCode = value;
                OnPropertyChanged("areaCode");
            }
        }

        public String AreaName
        {
            get { return areaName; }
            set
            {
                areaName = value;
                OnPropertyChanged("areaName");
            }
        }

        public bool? IsDeleted
        {
            get { return isDeleted; }
            set
            {
                isDeleted = value;
                OnPropertyChanged("isDeleted");
            }
        }
        #endregion

        #region Constructors
        public AreaModel()
        {
        }

        public AreaModel(string areaCode, string areaName)
        {
            AreaCode = areaCode;
            AreaName = areaName;
        }
        #endregion

        #region IDataErrorInfo Members
        string IDataErrorInfo.Error
        {
            get { return null; }
        }

        string IDataErrorInfo.this[string propertyName]
        {
            get { return GetValidationError(propertyName); }
        }
        #endregion

        #region Validation
        static readonly string[] ValidatedProperties = { "AreaCode", "AreaName" };

        public bool IsValid
        {
            get
            {
                foreach (string prop in ValidatedProperties)
                    if (GetValidationError(prop) != null)
                        return false;
                return true;
            }
        }

        private string GetValidationError(string propertyName)
        {
            string error = null;

            switch (propertyName)
            {
                case "AreaCode":
                    {
                        //Add validation code here...
                        if (string.IsNullOrEmpty(AreaCode))
                            error = "can not be null";
                        break;
                    }
                case "AreaName":
                    {
                        if (string.IsNullOrEmpty(AreaName))
                            error = "can not be null";
                        break;
                    }
            }

            return error;
        }
        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}


