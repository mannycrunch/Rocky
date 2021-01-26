using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(email, subject, htmlMessage);
        }

        public async Task Execute(string email, string subject, string body)
        {
            MailjetClient client = new MailjetClient("5e536c329eb2db680affbab9a06b2503", "29105d53414cae332f9df93194959c90")
            {
                //Version = ApiVersion.V3_1,
            };
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
             .Property(Send.Messages, new JArray {
                 new JObject {
                      {
                           "From",
                           new JObject {
                                {"Email", "manuel.lopez.jr@gmail.com"},
                                {"Name", "Manny"}
                           }
                      }, {
                           "To",
                           new JArray {
                                new JObject {
                                     {
                                          "Email",
                                          email
                                     }, {
                                          "Name",
                                          "DotNetMastery"
                                     }
                                }
                           }
                      }, {
                           "Subject",
                           subject
                      }, {
                           "HTMLPart",
                           body
                      }
                 }
             });
            //MailjetResponse response = await client.PostAsync(request);
            await client.PostAsync(request);
        }
    }
}
