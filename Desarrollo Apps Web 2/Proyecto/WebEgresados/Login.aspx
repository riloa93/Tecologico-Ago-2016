<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
  <title>Login Egresados</title>
    <link rel="stylesheet" type="text/css" href="css/style.css">
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="">
</head>

<body>
<header>
    <div style="text-align:center;">
        <img src="img/Logos.jpg" style="width:80%;" />
    </div>
</header>
<div class="container">
  <div class="row" id="pwd-container">
    <div class="col-md-4"></div>
    
    <div class="col-md-4">
        <section class="login-form">
        <form runat="server">
          <%--<img src="./img/Login/icon.png" class="img-responsive" alt="" />--%>
            <!--<input type="text" name="NoControl" placeholder="Num. de Control" required class="form-control form_cntrl input-lg" runat="server" id="txtNoCtrl" />-->
            <asp:TextBox ID="txtcontrol" runat="server" CssClass="form-control form_cntrl input-lg"></asp:TextBox>
            <!--<input type="password" class="form-control form_cntrl input-lg" id="password" placeholder="Contraseña" required="" runat="server"/>-->
            <asp:TextBox ID="txtPassw" runat="server" CssClass="form-control form_cntrl input-lg"></asp:TextBox>
            <!--<div class="pwstrength_viewport_progress"></div> 
            <!--<button type="button" class="btn btn-lg btn-primary btn_ses btn-block" runat="server" id="btnSesion" onserverclick="Page_PreInit" value="HTML Serve Control"> Sesión</button>-->
            <asp:Button ID="btnSsn" runat="server" Text="Iniciar Sesión" CssClass="btn btn-lg btn-primary btn_ses btn-block" OnClick="btnSsn_Click" />
          </form>
            <!--Modal-->
            <div>
            <a class="links_a" data-toggle="modal" data-target="#RegModal">Crear Cuenta</a> | <a class="links_a" data-toggle="modal" data-target="#ConModal">Olvidé mi contraseña</a>

            <div class="modal fade" id="RegModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                <div class="modal-dialog">
                    <div class="modal-content modal_bkgrd">
                        <div class="modal-header modal_bkgrd">
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">X</button>
                            <h3 class="modal-title"><span><i class="glyphicon glyphicon-user"></i></span> Enviar Solicitud</h3>
                        </div>
                        <div class="modal-body modal_bkgrd">
                          <div class="te">              
                          <!--REGISTRO DE UN USUARIO-->
                          <div class="container alineacion_registro">
                              <div class="row">
                                  <div class="col-xs-12 col-sm-12 col-md-4 well well-sm">
                                      <div class="row">
                                          <div class="col-xs-6 col-md-6">
                                              <input class="form-control" name="firstname" placeholder="Nombre(s)" type="text"
                                                  required="required" autofocus  id="Txt_Registro_Nombre" runat="server"/>
                                          </div>
                                          <div class="col-xs-6 col-md-6">
                                              <input class="form-control" name="lastname" placeholder="Apellido(s)" type="text" required="required" id="Txt_Registro_Apellido" runat="server"/>
                                          </div>
                                      </div>
                                      <input class="form-control" name="youremail" placeholder="Correo Electronico" type="email" id="Txt_Registro_Email" runat="server" required="required" />
                                      <input class="form-control" name="reenteremail" placeholder="Re-enter Email" type="email" id="Txt_Registro_ConEmail" runat="server" required="required"/>
                                      <input class="form-control" name="password" placeholder="Contrasena" type="password"  id="Txt_Registro_Contrasena" runat="server" required="required"/>
                                      <label for="">
                                          Birth Date</label>
                                      <div class="row">
                                          <div class="col-xs-4 col-md-4">
                                              <select class="form-control">
                                                  <option value="Month">Month</option>
                                              </select>
                                          </div>
                                          <div class="col-xs-4 col-md-4">
                                              <select class="form-control">
                                                  <option value="Day">Day</option>
                                              </select>
                                          </div>
                                          <div class="col-xs-4 col-md-4">
                                              <select class="form-control">
                                                  <option value="Year">Year</option>
                                              </select>
                                          </div>
                                      </div>
                                      <label class="radio-inline">
                                          <input type="radio" name="sex"  value="male" id="Registro_Hombre" required="required" runat="server" />Hombre</label>
                                      <label class="radio-inline">
                                          <input type="radio" name="sex"  value="female" id="Registro_Mujer" required="required" runat="server"/>Mujer</label>
                                      <br />
                                      <br />
                                      <button class="btn btn-lg btn-primary btn-block" type="submit"> Enviar Solicitud</button>
                                      <!--</form>-->
                                  </div>
                              </div>
                          </div>
                          <!--FIN DE REGISTRO DE UN USUARIO-->

                        </div>
                    </div>
                    <!-- /.modal-content -->
                </div>
                <!-- /.modal-dialog -->
            </div>
          </div>
          <!-- /.modal -->
        </form>
        
         <!--Modal Olvide Contrasena-->
          <div>
            <div class="modal fade" id="ConModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                <div class="modal-dialog width_modal">
                    <div class="modal-content modal_bkgrd">
                        <div class="modal-header modal_bkgrd">
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">X</button>
                            <h3 class="modal-title"><span><i class="glyphicon glyphicon-question-sign"></i></span> Olvidé mi contraseña</h3>
                        </div>
                        <div class="modal-body modal_bkgrd">
                          <div class="te">              
                          <!--Datos Para Envio-->
                          <div class="container alineacion_Olvido">
                            <div class="container">
                                <div class="row">
                                    <div class="col-md-8">
                                        <div class="well well-sm">
                                            <form>
                                            <div class="row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label for="name">
                                                            Numero de control: </label>
                                                        <input type="text" class="form-control" id="NoControl" placeholder="Ingresa tu numero de control" required="required" runat="server"  />
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="email:">
                                                            Respuesta:</label>
                                                        <div class="input-group">
                                                            <%--<span class="input-group-addon"><span class="glyphicon glyphicon-envelope"></span>
                                                            </span>--%>
                                                            <input type="email" class="form-control" id="email" placeholder="Ingresa tu respuesta" required="required" /></div>
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="subject">
                                                            Pregunta de seguridad</label>
                                                        <select id="preguntas" name="subject" class="form-control" required="required" runat="server" >
                                                            <option value="na" selected="">Pregunta de seguridad</option>
                                                            <option value="comidaFav">Comida favorita</option>
                                                            <option value="peliculaFav">Pelicula favorita</option>
                                                            <option value="añoUniv">Año de ingreso a la universidad</option>
                                                       
                                                        </select>
                                                    </div>
                                                </div>
                                              
                                                <div class="col-md-12">
                                                    <button type="submit" class="btn btn-primary pull-right" id="btnContactUs">
                                                        Continuar</button>
                                                </div>
                                            </div>
                                            </form>
                                        </div>
                                    </div>
                                </div>
                            </div>
                          </div>
                          <!--FIN DE REGISTRO DE UN USUARIO-->

                        </div>
                    </div>
                    <!-- /.modal-content -->
                </div>
                <!-- /.modal-dialog -->
            </div>
          </div>
          <!-- /.modal -->
        </form>

        <div class="form-links">
          <a href="http://www.itnogales.edu.mx/">Tecnológico de Nogales</a>
        </div>
      </section>  
      </div>
      <div class="col-md-4"></div>
  </div>       
</div>
    <script type="text/javascript" scr="js/login.js"></script>
    <script type="text/javascript" src="js/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
</body>
</html>