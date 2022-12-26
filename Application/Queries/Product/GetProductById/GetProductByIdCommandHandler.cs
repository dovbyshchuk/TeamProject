using Application.Models;
using AutoMapper;
using DAL.Repository;
using MediatR;

namespace Application.Queries.Product.GetProductById;

public class GetProductByIdCommandHandler : IRequestHandler<GetProductByIdQuery, ProductModel>
{
    private readonly IRepository<global::Models.Product> _repository;
    private readonly IMapper _mapper;
    public GetProductByIdCommandHandler(IRepository<global::Models.Product> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<ProductModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product = await _repository.GetById(request.Id);
        return _mapper.Map<ProductModel>(product);
    }
}