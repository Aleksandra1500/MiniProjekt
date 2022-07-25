using EnsureThat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjekt.DAL
{
    public class EmailRepository
    {
        private readonly DbEmails _context;

        public EmailRepository()
        {
            _context = new DbEmails();
        }
        public IList<Email> GetAllEmails()
        {
            return _context.adr_Email.ToList();
        }
    }
}
