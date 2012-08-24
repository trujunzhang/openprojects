using Model;

namespace HRMvcApplication.Models
{
    public class MechanismDetailModel
    {
        #region class fields 

        public C_Mechanism SelectedModel { get; set; }

        #endregion

        #region constructor

        public MechanismDetailModel(C_Mechanism cMechanism)
        {
            SelectedModel = cMechanism;
        }

        #endregion
    }
}