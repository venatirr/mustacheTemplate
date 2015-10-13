namespace mustacheTemplates
{
	public class HtmlTemplate : ITemplate
	{
		public string Template
		{
			get { return @"

<!doctype html>
<html>
<head>
<meta charset=""utf-8"">
<!-- TemplateBeginEditable name=""doctitle"" --><!-- TemplateEndEditable -->
<!-- TemplateBeginEditable name=""head"" --><!-- TemplateEndEditable -->
</head>

<body bgcolor=""#f7f3f8"">
    <table style=""text-align:left; margin:0 auto; table-layout:fixed; border-collapse: collapse;border-spacing: 0;"" width=""100%"">    	
        <tr bgcolor=""#f7f3f8"">
            <td bgcolor=""#f7f3f8"">
                <center>
                    <table style=""text-align:left; margin:0 auto; border-collapse: collapse; border-spacing: 0;"" width=""600"" align=""center"" cellspacing=""0"" cellpadding=""0"">
                       
                        <tr>
                        	<td>
                            	<table height=""100%"" style=""border-collapse: collapse; border-spacing: 0;"" cellspacing=""0"" cellpadding=""0"">	
                                    <tr colspan=""2"">
                                        <td colspan=""2"">
                                            <!-- TemplateBeginEditable name=""TopCorners"" -->
                                                <img src=""http://cdn.maxemail.emailcenteruk.com/c2377/0140adf68770a2dd1fc57dc3409b507c.png"" style=""display:block;"">
	                                          <!-- TemplateEndEditable -->
                                        </td>
                                    </tr>
                                    <tr colspan=""2"">
                                        <td colspan=""2"" style=""line-height:193px;"">
                                            <!-- TemplateBeginEditable name=""Banner Image"" -->
                                                <img src=""http://cdn.maxemail.emailcenteruk.com/c2377/bb7bd5d88c4a555b6807c3185566811d.png"" style=""display:block;"">
	                                          <!-- TemplateEndEditable -->
                                        </td>
                                    </tr>
                                    <tr>
                                    	<td bgcolor=""#ffffff"" width=""580"">
                                            <table width=""100%"" style=""border-collapse: collapse; border-spacing: 0;"" cellspacing=""0"" cellpadding=""0"">
                                                <tr width=""350"">
                                                	<td style=""padding-left:10px;"" width=""350"">
                                                        <span style=""font: 100% Calibri, Verdana, Arial, Helvetica, sans-serif; font-size:14px; color:#333333; width:350px;"" width=""350px""><br>
															<!-- TemplateBeginEditable name=""Body Copy"" -->You just put someone’s phone back in action<br>
                                                                We’ve copied your latest top-up details below in case you need them.<br>
                                                                Keep creating smiles, one ding* at a time.<br><br>
                                                                <center>
																<table width=""580"">
                                                                    <tbody bgcolor=""#ffffff""><tr>
                                                                        <th colspan=""2"" bgcolor=""#00196e"" style=""text-align:center; color:#ffffff;-webkit-border-top-left-radius: 8px;-webkit-border-top-right-radius: 8px;-moz-border-radius-topleft: 8px;-moz-border-radius-topright: 8px;border-top-left-radius: 8px;border-top-right-radius: 8px; font: 100% Calibri, Verdana, Arial, Helvetica, sans-serif; font-size:14px;""><b>Your Transaction Details</b></th>
                                                                    </tr>
                                                                    <tr>
                                                                        <td></td>
                                                                        <td></td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style=""color:#333333; font: 100% Calibri, Verdana, Arial, Helvetica, sans-serif; font-size:14px;"">Transaction ID</td>
                                                                        <td style=""color:#333333; font: 100% Calibri, Verdana, Arial, Helvetica, sans-serif; font-size:14px;""><b>{{Name}}</b></td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style=""color:#333333; font: 100% Calibri, Verdana, Arial, Helvetica, sans-serif; font-size:14px;"">Date &amp; Time</td>
                                                                        <td style=""color:#333333; font: 100% Calibri, Verdana, Arial, Helvetica, sans-serif; font-size:14px;""><b>{{Address.Name}}</b></td>
                                                                	</tr>
																</tbody></table>
																</center>
																<br><br>
                                                                We do everything we can to deliver your top-up instantly. However, now and then the process can take a little longer so please be patient. If you have any questions, please visit our <a href=""https://www.ding.com/support/faqs/top-up"" target=""_blank"" style=""color:#00196e; text-decoration:none;"">FAQ section</a>.<br><br>
																We'd love to hear your feedback: <a href=""https://www.surveymonkey.com/s/5KFFGK6"" target=""_blank"" style=""color:#00196e; text-decoration:none;"">https://www.surveymonkey.com/s/5KFFGK6</a><br><br>
<!-- TemplateEndEditable -->
                                                            <br>
                                                        </span>
                                                  	</td>
                                              	</tr>
                                                <tr>
                                                    <td align=""center"" style=""line-height:4px;"">
														<!-- TemplateBeginEditable name=""Call to Action"" -->
                                                        	<!--1--><img src=""http://cdn.maxemail.emailcenteruk.com/c2377/f92c1f5a8f9d80bd05a315095c2b549e.png"" style=""display:block;""><!--5--><a href=""https://www.ding.com/topup"" target=""_blank""><img src=""http://cdn.maxemail.emailcenteruk.com/c2377/81470398e0fccc235d24daa7523568b9.png"" style=""display:block;""></a><!--6--><img src=""http://cdn.maxemail.emailcenteruk.com/c2377/bcd35d5997792677c6928673769b0810.png"" style=""display:block;"">
														<!-- TemplateEndEditable -->
                                                  	</td>
                                               	</tr>
                                                <tr>
                                                	<td>
                                                        <br>
														<!-- TemplateBeginEditable name=""Social"" --><table width=""600"">
                                                                <tbody><tr width=""100%"">
                                                                    <td width=""9%"" align=""center"">
                                                                        <a href=""http://www.facebook.com/ding"" target=""_blank""><img src=""http://cdn.maxemail.emailcenteruk.com/c2377/03e0955a8899b59c2aea3b3f58eee220.png"" alt=""facebook""></a>
                                                                    </td> 
                                                                    <td width=""9%"" align=""center"">    
                                                                        <a href=""http://www.twitter.com/dingme"" target=""_blank""><img src=""http://cdn.maxemail.emailcenteruk.com/c2377/6b19205fe41e70cf3c3616cb05f7a553.png"" alt=""Twitter""></a>
                                                                    </td> 
                                                                    <td width=""9%"" align=""center"">         
                                                                        <a href=""http://www.pinterest.com/dingme/"" target=""_blank""><img src=""http://cdn.maxemail.emailcenteruk.com/c2377/3386713c042033df65cda8d2e7ebfc40.png"" alt=""Pinterest""></a>
                                                                    </td> 
                                                                    <td width=""9%"" align=""center"">                                                                            
                                                                        <a href=""https://www.youtube.com/user/dingtopup"" target=""_blank""><img src=""http://cdn.maxemail.emailcenteruk.com/c2377/269348a88244643ffb8475b82315f84a.png"" alt=""YouTube""></a>
                                                                    </td> 
                                                                    <td width=""9%"" align=""center"">                                                                           
                                                                        <a href=""https://plus.google.com/+Dingme/posts"" target=""_blank""><img src=""http://cdn.maxemail.emailcenteruk.com/c2377/f4ea82b2dee9316eb8f78bf11b8cca48.png"" alt=""Google+""></a>
                                                                    </td>
                                                                    <td width=""9%"" align=""center"">                                                                           
                                                                        <a href=""http://instagram.com/dingtopup"" target=""_blank""><img src=""http://cdn.maxemail.emailcenteruk.com/c2377/725c41972293148feb8ebc964e7ffb05.png"" alt=""Instagram""></a>
                                                                    </td>
                                                                    <td width=""23%"" align=""right"">                                                                                                                                              
                                                                        <a href=""http://go.onelink.ly/1921908221?pid=Platform_emails&amp;c=TopUp_Success_en&amp;af_dp=ezetopapp%3A%2F%2F&amp;af_web_dp=https%3A%2F%2Fwww.ding.com%2Fmobile-apps"" target=""_blank""><img src=""http://cdn.maxemail.emailcenteruk.com/c2377/da7e4f02591edc3e118f2989ec10f67e.png"" alt=""AppStore""></a>
                                                                	</td>        
                                                                	<td width=""23%"" align=""right"" style=""padding-right:10px"">        
                                                                        <a href=""http://go.onelink.ly/1921908221?pid=Platform_emails&amp;c=TopUp_Success_en&amp;af_dp=ezetopapp%3A%2F%2F&amp;af_web_dp=https%3A%2F%2Fwww.ding.com%2Fmobile-apps"" target=""_blank""><img src=""http://cdn.maxemail.emailcenteruk.com/c2377/0a0678e6cf1046d3e71600054a07ad8c.png"" alt=""PlayStore""></a>
                                                                	</td> 
                                                                </tr>
                                                        	</tbody></table>
                                                        	<br>       <!-- TemplateEndEditable -->
													</td>
                                               	</tr>
                                           	</table>
                                        </td>
                                    </tr>
                                    <tr colspan=""2"">
                                        <td colspan=""2"" style=""line-height:41px;"">
                                            <!-- TemplateBeginEditable name=""Bottom Corners"" -->
                                                <img src=""http://cdn.maxemail.emailcenteruk.com/c2377/f79650012ff904ec773d6b7c7e43ec5d.png"" style=""display:block;"">
	                                          <!-- TemplateEndEditable -->
                                        </td>
                                    </tr>
                               	</table>
                           	</td>
                       	</tr>
                        <tr>
                            <td colspan=""2"" style=""text-align:center"">
                                <span style=""font: 100% Calibri, Verdana, Arial, Helvetica, sans-serif; font-size:10px; color:#899496;"">
                                    This is your confirmation that you have agreed and authorised ezetop/ding to send Top Up to the recipient and that the relevant operator shall be solely liable to the recipient of Top Up for the provision of mobile services related to the Top Up.<br><br>
                                        
                                    <!-- TemplateBeginEditable name=""Footer"" -->
                                       
                                        <a href=""http://www.ding.com"" style=""color:#00196e; text-decoration:none; "">www.ding.com</a>
                                        is operated by ezetop t/a ding* | Registered in Ireland under company number 422514<br>
                                        Brooklawn House, Shelbourne Road, Dublin 4, Ireland.<br>
                                        Customer Phone: USA: 1877 853 8401, UK: 0800 31 666 18<br>
                                        LIVE Chat:<a href=""http://ezetop.force.com/resources/dingprechatform?endpoint=https%3A%2F%2F5csg.la2w2.salesforceliveagent.com%2Fcontent%2Fs%2Fchat%3Flanguage%3Den_US%23deployment_id%3D57220000000KzXh%26org_id%3D00D20000000CfmC%26button_id%3D57320000000Kzgb%26session_id%3D21a0bd1d-dd50-409d-b6e4-222639c53d45"" style=""color:#00196e; text-decoration:none;""> Online</a>,
                                        email:<a href=""mailto: customercare@ding.com"" style=""color:#00196e; text-decoration:none;"">customercare@ding.com</a>                
                                    <!-- TemplateEndEditable -->
                                </span>
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