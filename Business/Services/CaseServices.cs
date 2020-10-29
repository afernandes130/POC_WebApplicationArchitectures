namespace Business.Services
{
    using System.Threading.Tasks;

    using AutoMapper;

    using Business.Validators;
    using Core.Domain;
    using Core.Dtos;
    using Core.Repositories;


    class CaseServices : ICaseServices
    {
        /// <summary>
        /// The mapper.
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// The case repository.
        /// </summary>
        private readonly ICaseRepository _caseRepository;
        public CaseServices(IMapper mapper, ICaseRepository caseRepository)
        {
            _mapper = mapper;
            _caseRepository = caseRepository;
        }
        /// <summary>
        /// The create.
        /// </summary>
        /// <param name="caseDto">
        /// The case DTO.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<(ValidationResultDto, bool)> UpdateCase(CaseDto caseDto)
        {
            var validator = new CaseValidator();
            var validateAsync = await validator.ValidateAsync(caseDto);

            if (!validateAsync.IsValid)
            {
                var validationDto = _mapper.Map<ValidationResultDto>(validateAsync);
                return (validationDto, false);
            }

            var caseDomain = _mapper.Map<Case>(caseDto);

            var result = _caseRepository.Update(caseDomain);
            return (new ValidationResultDto(), result);

        }
       
    }
}
