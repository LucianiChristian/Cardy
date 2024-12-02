using FluentValidation;

namespace CardyWasm.Classes;

public class CardTemplateValidator : AbstractValidator<CardTemplate>
{
    public CardTemplateValidator()
    {
        // Validate Frames
        RuleForEach(x => x.Frames).SetValidator(new MaskConditionValidator());

        // Validate Masks
        RuleForEach(x => x.Masks).SetValidator(new MaskConditionValidator());

        // Validate Emblems
        RuleForEach(x => x.Emblems).SetValidator(new MaskConditionValidator());

        // Validate Icons
        RuleForEach(x => x.Icons).SetValidator(new IconConditionValidator());
    }
}

// Validator for MaskCondition
public class MaskConditionValidator : AbstractValidator<MaskCondition>
{
    public MaskConditionValidator()
    {
        RuleFor(x => x.ColumnName).NotNull().NotEmpty().WithMessage("ColumnName cannot be null or empty.");
        RuleFor(x => x.Value).NotNull().NotEmpty().WithMessage("Value cannot be null or empty.");
        RuleFor(x => x.ImgUrl).NotNull().NotEmpty().WithMessage("ImgUrl cannot be null or empty.");
        RuleFor(x => x.XCord).NotNull().NotEmpty().WithMessage("XCord cannot be null or empty.");
        RuleFor(x => x.YCord).NotNull().NotEmpty().WithMessage("YCord cannot be null or empty.");
        RuleFor(x => x.Height).NotNull().NotEmpty().WithMessage("Height cannot be null or empty.");
        RuleFor(x => x.Width).NotNull().NotEmpty().WithMessage("Width cannot be null or empty.");
    }
}

// Validator for IconCondition
public class IconConditionValidator : AbstractValidator<IconCondition>
{
    public IconConditionValidator()
    {
        RuleFor(x => x.Text).NotNull().NotEmpty().WithMessage("Text cannot be null or empty.");
        RuleFor(x => x.ImgUrl).NotNull().NotEmpty().WithMessage("ImgUrl cannot be null or empty.");
    }
}