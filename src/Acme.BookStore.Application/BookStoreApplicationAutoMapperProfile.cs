using Acme.BookStore.Authors;
using Acme.BookStore.Books;
using AutoMapper;
using static Acme.BookStore.Authors.AuthorAppService;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<BookDto, CreateUpdateBookDto>();
        CreateMap<Author, AuthorDto>();

        // ADD a NEW MAPPING
        CreateMap<CreateAuthorViewModel,
                    CreateAuthorDto>();
    }

}
