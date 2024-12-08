using FluentValidation;

namespace CardyWasm.Classes;

public class CardTemplateValidator : AbstractValidator<CardTemplate>
{
    public CardTemplateValidator()
    {
        // Validate Frames
        RuleForEach(x => x.Frames).NotEmpty().SetValidator(new MaskConditionValidator());

        // Validate Masks
        RuleForEach(x => x.Masks).NotEmpty().SetValidator(new MaskConditionValidator());

        // Validate Emblems
        RuleForEach(x => x.Emblems).NotEmpty().SetValidator(new MaskConditionValidator());

        // Validate Icons
        RuleForEach(x => x.Icons).NotEmpty().SetValidator(new IconConditionValidator());
    }
    public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
    {
        var result = await ValidateAsync(ValidationContext<CardTemplate>.CreateWithOptions((CardTemplate)model, x => x.IncludeProperties(propertyName)));
        if (result.IsValid)
            return Array.Empty<string>();
        return result.Errors.Select(e => e.ErrorMessage);
    };
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
    public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
    {
        var result = await ValidateAsync(ValidationContext<MaskCondition>.CreateWithOptions((MaskCondition)model, x => x.IncludeProperties(propertyName)));
        if (result.IsValid)
            return Array.Empty<string>();
        return result.Errors.Select(e => e.ErrorMessage);
    };
}

// Validator for IconCondition
public class IconConditionValidator : AbstractValidator<IconCondition>
{
    public IconConditionValidator()
    {
        RuleFor(x => x.Text).NotNull().NotEmpty().WithMessage("Text cannot be null or empty.");
        RuleFor(x => x.ImgUrl).NotNull().NotEmpty().WithMessage("ImgUrl cannot be null or empty.");
    }
    public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
    {
        var result = await ValidateAsync(ValidationContext<IconCondition>.CreateWithOptions((IconCondition)model, x => x.IncludeProperties(propertyName)));
        if (result.IsValid)
            return Array.Empty<string>();
        return result.Errors.Select(e => e.ErrorMessage);
    };
}