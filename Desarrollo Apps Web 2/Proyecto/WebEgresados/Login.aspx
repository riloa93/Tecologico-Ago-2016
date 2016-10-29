﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

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
        <form action="#">
          <img src="./img/Login/icon.png" class="img-responsive" alt="" />
            <input type="text" name="NoControl" placeholder="Num. de Control" required class="form-control form_cntrl input-lg" runat="server" id="txtNoCtrl" />
            <input type="password" class="form-control form_cntrl input-lg" id="password" placeholder="Contraseña" required="" runat="server"/>
            <div class="pwstrength_viewport_progress"></div> 
          <button type="submit" name="go" class="btn btn-lg btn-primary btn_ses btn-block" runat="server" id="btnSesion">Iniciar Sesión</button>
          
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
                                                  required autofocus />
                                          </div>
                                          <div class="col-xs-6 col-md-6">
                                              <input class="form-control" name="lastname" placeholder="Apellido(s)" type="text" required />
                                          </div>
                                      </div>
                                      <input class="form-control" name="youremail" placeholder="Correo Electronico" type="email" />
                                      <input class="form-control" name="reenteremail" placeholder="Re-enter Email" type="email" />
                                      <input class="form-control" name="password" placeholder="Contrasena" type="password" />
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
                                          <input type="radio" name="sex" id="inlineCheckbox1" value="male" />Hombre</label>
                                      <label class="radio-inline">
                                          <input type="radio" name="sex" id="inlineCheckbox2" value="female" />Mujer</label>
                                      <br />
                                      <br />
                                      <button class="btn btn-lg btn-primary btn-block" type="submit"> Enviar Solicitud</button>
                                      </form>
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
                                                            Name</label>
                                                        <input type="text" class="form-control" id="name" placeholder="Enter name" required="required" />
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="email">
                                                            Email Address</label>
                                                        <div class="input-group">
                                                            <span class="input-group-addon"><span class="glyphicon glyphicon-envelope"></span>
                                                            </span>
                                                            <input type="email" class="form-control" id="email" placeholder="Enter email" required="required" /></div>
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="subject">
                                                            Subject</label>
                                                        <select id="subject" name="subject" class="form-control" required="required">
                                                            <option value="na" selected="">Choose One:</option>
                                                            <option value="service">General Customer Service</option>
                                                            <option value="suggestions">Suggestions</option>
                                                            <option value="product">Product Support</option>
                                                        </select>
                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label for="name">
                                                            Message</label>
                                                        <textarea name="message" id="message" class="form-control" rows="9" cols="25" required="required"
                                                            placeholder="Message"></textarea>
                                                    </div>
                                                </div>
                                                <div class="col-md-12">
                                                    <button type="submit" class="btn btn-primary pull-right" id="btnContactUs">
                                                        Send Message</button>
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