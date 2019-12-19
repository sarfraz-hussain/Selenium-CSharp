using System;


namespace ReturnStatus
{
    public class Status : IEquatable<Status>
    {
        private bool errorOccurred;
        private string returnedMessage;
        private int returnedValue;

        #region Constructor

        public Status(bool errorOccurred)
        {
            this.returnedMessage = "";
            this.errorOccurred = errorOccurred;
            this.returnedValue = 0;
        }
        
        public Status(bool errorOccurred, string returnedMessage)
        {
            this.returnedMessage = returnedMessage;
            this.errorOccurred = errorOccurred;
            this.returnedValue = 0;
        }

        public Status(bool errorOccurred, string returnedMessage, int returnedValue)
        {
            this.returnedMessage = returnedMessage;
            this.errorOccurred = errorOccurred;
            this.returnedValue = returnedValue;
        }

        #endregion

        #region Properties

        public bool ErrorOccurred
        {
            set
            {
                errorOccurred = value;
            }
            get
            {
                return errorOccurred;
            }
        }
                
        public string ReturnedMessage
        {
            set
            {
                returnedMessage = value;
            }
            get
            {
                return returnedMessage;
            }
        }

        public int ReturnedValue
        {
            set
            {
                returnedValue = value;
            }
            get
            {
                return returnedValue;
            }
        }

        #endregion

        public override bool Equals(object obj)
        {
            if (!(obj is Status))
                return false;

            return Equals((Status)obj);
        }    

        public bool Equals(Status other)
        {
            try
            {
                if (ReturnedMessage == null && other.ReturnedMessage == null)
                {
                    if (ErrorOccurred == other.ErrorOccurred && ReturnedValue == other.ReturnedValue)
                        return true;
                    else
                        return false;
                }
                else if (ReturnedMessage != null && other.ReturnedMessage != null)
                {
                    if (ErrorOccurred == other.ErrorOccurred && ReturnedValue == other.ReturnedValue
                        && ReturnedMessage.Equals(other.ReturnedMessage))
                        return true;
                    else
                        return false;
                }
                else 
                {
                    return false;
                }
                
            }
            catch (ArgumentNullException)
            {
                return false;
            }
        }

        public static bool operator ==(Status returnStatus1, Status returnStatus2)
        {
            return returnStatus1.Equals(returnStatus2);
        }

        public static bool operator !=(Status returnStatus1, Status returnStatus2)
        {
            return !returnStatus1.Equals(returnStatus2);
        }

        public override int GetHashCode()
        {
            return returnedValue*returnedValue;
        }
    }
}
