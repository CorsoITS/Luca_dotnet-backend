using projectwork.Repositories;
using projectwork.Models;

namespace projectwork.Services;


public class OperatoreService
{

    private OperatoreRepository operatoreRepository = new OperatoreRepository();

    public IEnumerable<Operatore> GetOperatori()
    {
        return operatoreRepository.GetOperatori();
    }

    public Operatore GetOperatore(int id)
    {
        return operatoreRepository.GetOperatore(id);
    }

    public bool Create(Operatore operatore)
    {
        if (operatoreRepository.GetOperatore(operatore.id) == null)
        {
            
            {
                return operatoreRepository.Create(operatore);
            }
        }
        else
        {
            return false;
        }

    }

    public bool Update(Operatore operatore)
    {
        return operatoreRepository.Update(operatore);
    }

    public bool Delete(int id)
    {
        return operatoreRepository.Delete(id);
    }


}