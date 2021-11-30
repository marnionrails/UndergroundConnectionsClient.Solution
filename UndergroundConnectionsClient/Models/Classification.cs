using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CretaceousClient.Models
{
  public class Classification
  {
    public int ClassificationId { get; set; }
    public string ClassificationName { get; set; }
    public string ClassificationSpecification { get; set; }

    public static List<Classification> GetClassifications()
    {
      var apiCallTask = ApiHelperClassification.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Classification> classificationList = JsonConvert.DeserializeObject<List<Classification>>(jsonResponse.ToString());

      return classificationList;
    }
  }
}