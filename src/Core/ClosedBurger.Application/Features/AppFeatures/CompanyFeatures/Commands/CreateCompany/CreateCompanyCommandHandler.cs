﻿using ClosedBurger.Application.Messaging;
using ClosedBurger.Application.Services.AppServices;
using ClosedBurger.Domain.AppEntities;
namespace ClosedBurger.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
public sealed class CreateCompanyCommandHandler : ICommandHandler<CreateCompanyCommand, CreateCompanyCommandResponse>
{
    private readonly ICompanyService _companyService;
    public CreateCompanyCommandHandler(ICompanyService companyService)
    {
        _companyService = companyService;
    }
    public async Task<CreateCompanyCommandResponse> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
    {
        Company company = await _companyService.GetCompanyByName(request.Name, cancellationToken);
        if (company != null) throw new Exception("Bu şirket adı daha önce kullanılmış!");

        await _companyService.CreateCompany(request, cancellationToken);
        return new();
    }
}