using Microsoft.EntityFrameworkCore;

namespace faatcar_tcc.Data
{
    public class BancoContext:DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options): base(options) {  }
    }

}
