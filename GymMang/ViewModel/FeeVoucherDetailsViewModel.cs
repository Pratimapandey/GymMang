using GymMang.Models;

namespace GymMang.ViewModel
{
    public class FeeVoucherDetailsViewModel
    {
        public GymTrainee gymTrainee { get; set; }
        public MonthlyFeeVoucher monthlyFeeVoucher { get; set; }


        public IEnumerable<GymTrainee> list_GymTrainee { get; set; }

        public IEnumerable<MonthlyFeeVoucher> list_MonthlyFeeVoucher { get; set; }
    }
}
