using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace EscolaDBWinForm.Controller
{
    public class ModelDataValidation
    {
        //Usa as Data Anotations para validar os dados de todos os Models
        public void ValidateModelData(object model)
        {
            string errorMessage = string.Empty;
            var validationContext = new ValidationContext(model);
            var validationResults = new List<ValidationResult>();
            //Validator helper class 
            bool isValid = Validator.TryValidateObject(model, validationContext, validationResults, true);
            //Se o model nao for valido
            if (!isValid)
            {
                //Percorre a lista de resultados de validacao
                foreach (var validationResult in validationResults)
                {
                    //Concatena a mensagem de erro
                    errorMessage += validationResult.ErrorMessage + Environment.NewLine;
                }
                //Se a data do model nao for valida essa exeption e lancada e apanhada pelo Controller e a menssagem de erro e mostrada na View
                //A Mensagem de erro pode ser definida em Data Anotations direto no Model
                throw new Exception(errorMessage);
            }

        }
    }
}
