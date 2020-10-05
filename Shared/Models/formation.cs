using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mediwatch.Shared.Models
{
  [Table ("Formation")]
  public class formation
  {
    [Key]
    public int id {get; set;}
    public int idCompagny {get; set;}
    public string formationName {get; set;}
    public DateTime createdAt{get; set;}
    public DateTime formationTime {get; set;}
    public string address {get; set;}
    public string talker {get; set;}
    public string description {get; set;}
    public bool free {get; set;}
    public List<tag> tagsFormation {get; set;}
    public List<applicant_session> applicantsSessions {get; set;}
  }
}