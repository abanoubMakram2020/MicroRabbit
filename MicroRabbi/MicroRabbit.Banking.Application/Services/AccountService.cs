using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepositry _accountRepository;

        public AccountService(IAccountRepositry accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public IEnumerable<Account> GetAccouns()
        {
            return _accountRepository.GetAccounts();
        }
    }
}
