using Xunit;

namespace DuckTube.CatalogUnitTests.Domain.Entity.Category;

public class CategoryTest
{
    [Fact(DisplayName = nameof(Instatiate))]
    [Trait("Domain", "Category - Agregates")]
    public void Instatiate()
    {
        //Arange
        var validData = new
        {
            Name = "Category Name",
            Description = "Category Description",
        };

        //Act
        var category = new Category(validData.Name, validData.Description);
        
        //Assert
        Assert.NotNull(category);
        Assert.Equal(validData.Name, category.Name);
        Assert.Equal(validData.Description, category.Description);
     }
}

