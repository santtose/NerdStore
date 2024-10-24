using NerdStore.Core.DomainObjects;
using NerdStote.Catalogo.Domain;

namespace NerdStore.catalogo.Domain.Tests
{
    public class CategoriaTests
    {
        [Fact]
        public void Categoria_Validar_ValidacoesDevemRetornarExceptions()
        {
            var ex = Assert.Throws<DomainException>(() =>
                new Categoria(string.Empty, 10)
            );

            Assert.Equal("O campo Nome da categoria não pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Categoria("Nome Qualquer", 0)
            );

            Assert.Equal("O campo Codigo não pode ser 0", ex.Message);
        }
    }
}
