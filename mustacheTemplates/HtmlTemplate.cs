namespace mustacheTemplates
{
	public class HtmlTemplate : ITemplate
	{
		public string Template
		{
			get { return @"

<!DOCTYPE html>
<html><head>
    <!--PLATFORM EMAIL CENTERED EN-->
<meta charset=""utf-8"">
<!-- TemplateBeginEditable name=""doctitle"" --><!-- TemplateEndEditable -->
<!-- TemplateBeginEditable name=""head"" --><!-- TemplateEndEditable -->
<link rel=""icon"" type=""image/png"" href=""http://cdn.maxemail.emailcenteruk.com/c2377/733a01626c5c7b26cf07e8b7e8cffc08.png"">    
<style type=""text/css"">
    
a:link {color: #00196e; text-decoration: none; }
a:active {color: #00196e; text-decoration: none; }
a:visited {color: #00196e; text-decoration: none; }
a:hover {color: #00196e; text-decoration: none; }

        

a.cta:link {color: #ffffff; text-decoration: none; }
a.cta:active {color: #ffffff; text-decoration: none; }
a.cta:visited {color: #ffffff; text-decoration: none; }
a.cta:hover {color: #ffffff; text-decoration: none; }

@media only screen and (max-width:480px) { 
    /* mobile-specific CSS styles go here */
        .container { 
            width: 280px !important;
            text-align:left; 
        	margin:0 auto;
        	border-collapse: collapse;
        	border-spacing: 0;
        }
  		
    	.buttonStyle { 
            width: 90%;
        }
    	
    	.cellFloat{
            width:100%;
            max-width:250px;
        }
    	
    }

 
img { display: block; }
</style>
</head>

<body bgcolor=""#f7f3f8"">
    <table style=""text-align:left; margin:0 auto; table-layout:fixed; border-collapse: collapse;border-spacing: 0;"" width=""100%"" bgcolor=""#f7f3f8"">
        <tr>
     		<td bgcolor=""#f7f3f8"">
                <!-- TemplateBeginEditable name=""Preview text for Email Clients"" -->
                <div style=""display:none; display:none !important; color:#f7f3f8;"">
                            ding* - 
                </div>
                <!-- TemplateEndEditable -->
                <br>
                <center>
               		<table class=""container"" style=""text-align:left; margin:0 auto; border-collapse: collapse; border-spacing: 0; width:600px;"" align=""center"" cellspacing=""0"" cellpadding=""0"">
                        <tr>
                   			<td>
                      			<table height=""100%"" style=""border-collapse: collapse; border-spacing: 0;"" cellspacing=""0"" cellpadding=""0"">
                                    <tr>
                        				<td bgcolor=""#ffffff"" style=""width:580px; -webkit-border-radius: 4px;-moz-border-radius: 4px;border-radius: 4px;"">
                                        	<table width=""100%"" style=""border-collapse: collapse; border-spacing: 0;"" cellspacing=""0"" cellpadding=""0"">
                                                <tr>
                                                	<td align=""center"">
														<!-- TemplateBeginEditable name=""dingLogo"" -->
                                                        	<br><img src=""http://cdn.maxemail.emailcenteruk.com/c2377/c8d16e560bc5208a5a9398fa716e0881.png"" style=""display:block;"">
                                                        <!-- TemplateEndEditable -->
                                                  	</td>
                                               	</tr>    
                                                <tr>
                                                    <td class=""contentPadding"" style=""padding-left:20px; padding-right:20px;"">
                                                    	<span style=""font: 100% Arial, Verdana, Helvetica, sans-serif; font-size:16px; color:#4c4c4c;"">
                                                            <hr color=""#f2f2f2"">
															 <!-- TemplateBeginEditable name=""Header Copy"" -->                                                      
                                                            <h3 style=""font: 100% Arial, Verdana, Helvetica, sans-serif; mso-line-height-rule:exactly; line-height:22px; font-size:20px; color:#4c4c4c;""><b>Your top-up has been sent.</b></h3>
                                                            <!-- TemplateEndEditable -->
                                                            
                                                            <!-- TemplateBeginEditable name=""Body Copy"" --><p style=""mso-line-height-rule:exactly; line-height:18px;"">You just put someone’s phone back in action.<br> 
                                                                We’ve copied your latest top-up details below in case you need them.<br><br>
																
                                                                </p><center>
                                                                <table width=""100%"">
                                                                        <tbody bgcolor=""#ffffff""><tr>
                                                                            <th colspan=""2"" bgcolor=""#00196e"" height=""30px"" style=""text-align:center; color:#ffffff;-webkit-border-top-left-radius: 8px;-webkit-border-top-right-radius: 8px;-moz-border-radius-topleft: 8px;-moz-border-radius-topright: 8px;border-top-left-radius: 8px;border-top-right-radius: 8px; font: 100% Arial, Helvetica, sans-serif; font-size:16px;""><b>Details</b><br></th>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                            	<table class=""cellFloat"" align=""left"" width=""40%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px; min-width:200px;""></table>
                                                                            	<table class=""cellFloat"" align=""left"" width=""60%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px; min-width:200px;""></table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                            	<table class=""cellFloat"" align=""left"" width=""40%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px;  min-width:200px;""><tbody><tr><td style=""text-align:left;"">Transaction ID</td></tr></tbody></table>
                                                                            	<table class=""cellFloat"" align=""left"" width=""60%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px;  min-width:200px;""><tbody><tr><td style=""text-align:left;""><b>{{OrderId}}</b></td></tr></tbody></table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                            	<table class=""cellFloat"" align=""left"" width=""40%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px;  min-width:200px;""><tbody><tr><td style=""text-align:left;"">Date &amp; Time</td></tr></tbody></table>
                                                                            	<table class=""cellFloat"" align=""left"" width=""60%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px;  min-width:200px;""><tbody><tr><td style=""text-align:left;""><b>{{OrderDateEst}}</b></td></tr></tbody></table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                            	<table class=""cellFloat"" align=""left"" width=""40%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px;  min-width:200px;""><tbody><tr><td style=""text-align:left;"">Amount Sent:</td></tr></tbody></table>
                                                                            	<table class=""cellFloat"" align=""left"" width=""60%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px;  min-width:200px;""><tbody><tr><td style=""text-align:left;""><b>{{SelectedTopUpAmountToDestinationCountry}}</b></td></tr></tbody></table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                            	<table class=""cellFloat"" align=""left"" width=""40%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px;  min-width:200px;""><tbody><tr><td style=""text-align:left;"">Top-Up Received:</td></tr></tbody></table>
                                                                            	<table class=""cellFloat"" align=""left"" width=""60%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px;  min-width:200px;""><tbody><tr><td style=""text-align:left;""><b>{{ReceivedTopUpAmountIncTaxToDestinationCountry}} [? inc. {{TaxName}}?]</b></td></tr></tbody></table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                            	[?<table class=""cellFloat"" align=""left"" width=""40%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px;  min-width:200px;""><tbody><tr><td style=""text-align:left;""></td></tr></tbody></table>
                                                                            	<table class=""cellFloat"" align=""left"" width=""60%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px;  min-width:200px;""><tbody><tr><td style=""text-align:left;""><b>{{ReceivedTopUpAmountExTaxToDestinationCountry}} (Mobile TopUp)</b></td></tr></tbody></table>?]
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                            	<table class=""cellFloat"" align=""left"" width=""40%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px;  min-width:200px;""><tbody><tr><td style=""text-align:left;"">Amount Paid:</td></tr></tbody></table>
                                                                            	<table class=""cellFloat"" align=""left"" width=""60%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px;  min-width:200px;""><tbody><tr><td style=""text-align:left;""><b>{{PaymentAmountToDestinationCountry}}</b></td></tr></tbody></table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                            	[?<table class=""cellFloat"" align=""left"" width=""40%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px;  min-width:200px;""><tbody><tr><td style=""text-align:left;"">Promotional Discount</td></tr></tbody></table>
                                                                            	<table class=""cellFloat"" align=""left"" width=""60%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px;  min-width:200px;""><tbody><tr><td style=""text-align:left;""><b>{{PromotionalDiscount}}</b></td></tr></tbody></table>?]
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                            	<table class=""cellFloat"" align=""left"" width=""40%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px;  min-width:200px;""><tbody><tr><td style=""text-align:left;"">Phone Number</td></tr></tbody></table>
                                                                            	<table class=""cellFloat"" align=""left"" width=""60%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px;  min-width:200px;""><tbody><tr><td style=""text-align:left;""><b>{{RechargePhoneNumber}}</b></td></tr></tbody></table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                            	<table class=""cellFloat"" align=""left"" width=""40%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px;  min-width:200px;""><tbody><tr><td style=""text-align:left;"">Country of Recipient</td></tr></tbody></table>
                                                                            	<table class=""cellFloat"" align=""left"" width=""60%"" style=""color:#4c4c4c; font: 100% Arial, Helvetica, sans-serif; font-size:16px;  min-width:200px;""><tbody><tr><td style=""text-align:left;""><b>{{OperatorCountry}}</b></td></tr></tbody></table>
                                                                            </td>
                                                                        </tr>
                                                                       	<tr>
                                                                          	<th colspan=""2"" bgcolor=""#f7f3f8"" style=""text-align:center; color:#ffffff""></th>
                                                                    	</tr>
                                                                        
                                                                        </tbody>
                                                                    </table>   
																</center>
                                                                <br><br>
																<p style=""mso-line-height-rule:exactly; line-height:18px;"">
                                                                    We do everything we can to deliver your top-up instantly. However, now and then the process can take a little longer so please be patient. If you have any questions, <a href=""https://www.ding.com/support/help"" target=""_blank"" style=""color:#00196e; text-decoration:underline;"">please visit our&nbsp;FAQ section.</a>
																<br><br>
                                                                </p>
                                                            <!-- TemplateEndEditable -->
                                                            <br>
                                                        </span>
                                                  	</td>
                                              	</tr>
                                                <tr>
                                                	<td>
                                                      	<center>
                                                           	<div>
                                                            	<table class=""buttonStyle"" width=""50%"" style=""margin:0 auto; border-collapse: collapse; border-spacing: 0; align:center; "">
                                                                    <tr>
                                                                      	<td align=""center"" width=100% height=""50"" bgcolor=""#00196e"" style=""color: #ffffff; border-radius: 4px 4px 4px 4px;-moz-border-radius: 4px 4px 4px 4px;-webkit-border-radius: 4px 4px 4px 4px;"">
                                                                           	<span style=""font-size:20px; font-family: Arial, sans-serif; text-decoration: none; line-height:50px; color:#ffffff;"">
                                                                                <!-- TemplateBeginEditable name=""CTA copy"" -->
                                                                                	<a href=""https://www.ding.com"" style=""color:#ffffff; text-decoration:none; padding:5% 15% 5% 15%;"">Send another top-up</a>
                                                                                <!-- TemplateEndEditable -->
                                                                            </span>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                           	</div>
                                                     	</center>
                                                        <br>&nbsp;
                                                     </td>
                                               	</tr>
                                                <tr>
                                                    <td class=""contentPadding"" style=""padding-left:20px; padding-right:20px;"">
                                                        <center>
                                                            <span style=""font: 100% Arial, Verdana, Helvetica, sans-serif; font-size:16px; color:#4c4c4c;"">
                                                                <!-- TemplateBeginEditable name=""Extra Section"" -->[?{{HasReferralCampaign}}<p style=""mso-line-height-rule:exactly; line-height:18px;""><a href=""http://www.ding.com/vouchers"" target=""_blank"" style=""text-decoration: underline;"">Did you know you can also invite friends to ding* and earn free top-up?</a></p>?] <!-- TemplateEndEditable -->
                                                                <br>
                                                            </span>
                                                        </center>
                                                  	</td>
                                              	</tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                           	</td>
                       	</tr>         
						<tr>
                           <td>
                              	<table width=""100%"" style=""text-align:center;"">
                        			<tr>
                           				<td>
                                            <br>
                                            <center>
                                                <table width=""100%"" align=""center"" style=""margin:0 auto; table-layout:fixed; border-collapse: collapse;border-spacing: 0;text-align:center;"" cellspacing=""0"" cellpadding=""0"">
                                                    <tr width=""100%"">
                                                        <!--<td width=""50%"" align=""center"">                                                                                                                                              
                                                            <span style=""font: 100% Arial, Verdana, Helvetica, sans-serif; font-size:14px; color:#666666;""><b>DOWNLOAD OUR APPS</b></span>
                                                        </td>-->
                                                        <td width=""48%"" align=""right"">                                                                                                                                              
                                                           <a href=""http://m.onel.ink/566bc440"" target=""_blank""><img src=""http://cdn.maxemail.emailcenteruk.com/c2377/cc061d4dfd83c894f10615aa6a404b87.png"" alt=""AppStore"" style=""padding-right:10px;"" border=""0""></a>
                                                        </td>
                                                        <td width=""4%"" align=""center"">                                                                                                                                              
                                                           <img src=""http://cdn.maxemail.emailcenteruk.com/c2377/62c37adb45245c1cc79b2e8bb4250947.png"" width=""10"" height=""10"" border=""0"">
                                                        </td>
                                                        <td width=""48%"" align=""left"">        
                                                            <a href=""http://m.onel.ink/566bc440"" target=""_blank""><img src=""http://cdn.maxemail.emailcenteruk.com/c2377/5b5ea38f2dc1701488eff52aa607cc89.png"" alt=""PlayStore"" border=""0""></a>
                                                        </td> 
                                                    </tr>
                                              	</table>
                                            </center>
                                            <br>
                                        </td>
                                    </tr>
                               </table> 
							</td>
                        </tr>
                        <tr>
                           <td>
                               <table width=""96%"" style=""text-align:center;"">
                                    <tr>
                                        <td colspan=""3"" style=""text-align:center"">
                                            <span class=""footer"" style=""font: 100% Calibri, Verdana, Arial, Helvetica, sans-serif; font-size:10px; color:#666666; -webkit-text-size-adjust: none;"">
                                                ezetop t/a ding* is registered in Ireland under company number 422514<br>
												Brooklawn House, Shelbourne Road, Dublin 4, Ireland.<br><br>			
                                                This is your confirmation that you have agreed and authorised ezetop/ding to send Top Up to the recipient and that the relevant operator shall be solely liable to the recipient of Top Up for the provision of mobile services related to the Top Up.
                                                <br><br> 
                                            </span>
                                        </td>
                                    </tr>
                               </table>
                            </td>
                        </tr>
                        <tr>
                           <td>
                               <table width=""100%"" style=""text-align:center;"">
                        			<tr>
                           				<td>
                                            <center>
                                                <table width=""100%"" style=""margin:0 auto; table-layout:fixed; border-collapse: collapse;border-spacing: 0;text-align:center;"" align=""center"">
                                                    <tr>
                                            	        <td style=""text-align:center;""> 
                                                         	<a href=""http://www.facebook.com/ding"" target=""_blank"">
                                                                <img src=""http://cdn.maxemail.emailcenteruk.com/c2377/bede9350245803a87a5b90b42c457366.png"" alt=""facebook"" style=""display:inline;"" border=""0"">
                                                            </a>
                                                            <a href=""http://www.twitter.com/dingme"" target=""_blank"">
                                                                <img src=""http://cdn.maxemail.emailcenteruk.com/c2377/8b8a1d67819ffca7748bd5c513cf85b4.png"" alt=""twitter"" style=""display:inline;"" border=""0"">
                                                            </a>
                                                         </td>
                                                   	</tr>
                                                </table>
                                            </center>
                           				</td>
                       				</tr>
                               </table>
                            </td>
                        </tr>
                    </table>
            	</center>
            </td>
        </tr>
    </table>
</body>
</html>


"; }
		}
	}
}