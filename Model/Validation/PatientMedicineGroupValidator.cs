using FluentValidation;

namespace PatientsMedicines.Model.Validation
{
    public class PatientMedicineGroupValidator : AbstractValidator<PatientMedicineGroupViewModel>
    {
        public PatientMedicineGroupValidator()
        {
            RuleFor(x => x.MedicineGroupId)
                .NotEmpty()
                .WithMessage("Medicine group must be provided!");

            RuleFor(x => x.PatientId)
                .NotEmpty()
                .WithMessage("Patient must be provided!");
        }
    }
}
