<?php

/* base.html.twig */
class __TwigTemplate_5da30f89f30a35c9a5555cd5587535c8940e4383322a88417eccd0aec44f1303 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'header' => array($this, 'block_header'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
            'javascripts' => array($this, 'block_javascripts'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_e028cfad5f80fcc438208244400bde26f4610b49d9d5ec0ddd3d7f0844f14538 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e028cfad5f80fcc438208244400bde26f4610b49d9d5ec0ddd3d7f0844f14538->enter($__internal_e028cfad5f80fcc438208244400bde26f4610b49d9d5ec0ddd3d7f0844f14538_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 11
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 12
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">

";
        // line 21
        $this->displayBlock('header', $context, $blocks);
        // line 39
        echo "
<div class=\"container body-container\">
    ";
        // line 41
        $this->displayBlock('body', $context, $blocks);
        // line 48
        echo "</div>


";
        // line 51
        $this->displayBlock('javascripts', $context, $blocks);
        // line 57
        echo "
</body>
</html>
";
        
        $__internal_e028cfad5f80fcc438208244400bde26f4610b49d9d5ec0ddd3d7f0844f14538->leave($__internal_e028cfad5f80fcc438208244400bde26f4610b49d9d5ec0ddd3d7f0844f14538_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_8ff51aa88ba0f2197aa403c835a6cfc0525d5556ca658e916dcd13d8de72672d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8ff51aa88ba0f2197aa403c835a6cfc0525d5556ca658e916dcd13d8de72672d->enter($__internal_8ff51aa88ba0f2197aa403c835a6cfc0525d5556ca658e916dcd13d8de72672d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Calculator";
        
        $__internal_8ff51aa88ba0f2197aa403c835a6cfc0525d5556ca658e916dcd13d8de72672d->leave($__internal_8ff51aa88ba0f2197aa403c835a6cfc0525d5556ca658e916dcd13d8de72672d_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_ae7651f3f2d4b7c37906bd52c75c655c2ac26cc74912deca9662b16b78811f51 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ae7651f3f2d4b7c37906bd52c75c655c2ac26cc74912deca9662b16b78811f51->enter($__internal_ae7651f3f2d4b7c37906bd52c75c655c2ac26cc74912deca9662b16b78811f51_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/bootstrap-datetimepicker.min.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_ae7651f3f2d4b7c37906bd52c75c655c2ac26cc74912deca9662b16b78811f51->leave($__internal_ae7651f3f2d4b7c37906bd52c75c655c2ac26cc74912deca9662b16b78811f51_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_46137d4377798fc017488eae5202bd4851130e87059a562ce1303ab4331eb05f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_46137d4377798fc017488eae5202bd4851130e87059a562ce1303ab4331eb05f->enter($__internal_46137d4377798fc017488eae5202bd4851130e87059a562ce1303ab4331eb05f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_46137d4377798fc017488eae5202bd4851130e87059a562ce1303ab4331eb05f->leave($__internal_46137d4377798fc017488eae5202bd4851130e87059a562ce1303ab4331eb05f_prof);

    }

    // line 21
    public function block_header($context, array $blocks = array())
    {
        $__internal_1b3152737035bf0be53b499c37d22cc3bcff898951d81a2e9254c54bc4d7a1a2 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1b3152737035bf0be53b499c37d22cc3bcff898951d81a2e9254c54bc4d7a1a2->enter($__internal_1b3152737035bf0be53b499c37d22cc3bcff898951d81a2e9254c54bc4d7a1a2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        // line 22
        echo "    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"";
        // line 26
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
";
        
        $__internal_1b3152737035bf0be53b499c37d22cc3bcff898951d81a2e9254c54bc4d7a1a2->leave($__internal_1b3152737035bf0be53b499c37d22cc3bcff898951d81a2e9254c54bc4d7a1a2_prof);

    }

    // line 41
    public function block_body($context, array $blocks = array())
    {
        $__internal_a58697cfd3682d7dc96bac39becdeab3cf01d42a703d12acd8ec1b17e43fde9d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a58697cfd3682d7dc96bac39becdeab3cf01d42a703d12acd8ec1b17e43fde9d->enter($__internal_a58697cfd3682d7dc96bac39becdeab3cf01d42a703d12acd8ec1b17e43fde9d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 42
        echo "        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                ";
        // line 44
        $this->displayBlock('main', $context, $blocks);
        // line 45
        echo "            </div>
        </div>
    ";
        
        $__internal_a58697cfd3682d7dc96bac39becdeab3cf01d42a703d12acd8ec1b17e43fde9d->leave($__internal_a58697cfd3682d7dc96bac39becdeab3cf01d42a703d12acd8ec1b17e43fde9d_prof);

    }

    // line 44
    public function block_main($context, array $blocks = array())
    {
        $__internal_ba572109bbd94587f226424b7c34a037e83d2d2b2935ccbce783ef2934f4a27b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ba572109bbd94587f226424b7c34a037e83d2d2b2935ccbce783ef2934f4a27b->enter($__internal_ba572109bbd94587f226424b7c34a037e83d2d2b2935ccbce783ef2934f4a27b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_ba572109bbd94587f226424b7c34a037e83d2d2b2935ccbce783ef2934f4a27b->leave($__internal_ba572109bbd94587f226424b7c34a037e83d2d2b2935ccbce783ef2934f4a27b_prof);

    }

    // line 51
    public function block_javascripts($context, array $blocks = array())
    {
        $__internal_42e925b72294bdfb6b8336255616bb0dc99384bee04b4cb6d872387112be4289 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_42e925b72294bdfb6b8336255616bb0dc99384bee04b4cb6d872387112be4289->enter($__internal_42e925b72294bdfb6b8336255616bb0dc99384bee04b4cb6d872387112be4289_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        // line 52
        echo "    <script src=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/jquery-2.2.4.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 53
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/moment.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 54
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 55
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap-datetimepicker.min.js"), "html", null, true);
        echo "\"></script>
";
        
        $__internal_42e925b72294bdfb6b8336255616bb0dc99384bee04b4cb6d872387112be4289->leave($__internal_42e925b72294bdfb6b8336255616bb0dc99384bee04b4cb6d872387112be4289_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  205 => 55,  201 => 54,  197 => 53,  192 => 52,  186 => 51,  175 => 44,  166 => 45,  164 => 44,  160 => 42,  154 => 41,  134 => 26,  128 => 22,  122 => 21,  111 => 19,  102 => 14,  97 => 13,  91 => 12,  79 => 11,  69 => 57,  67 => 51,  62 => 48,  60 => 41,  56 => 39,  54 => 21,  49 => 19,  42 => 16,  40 => 12,  36 => 11,  29 => 6,);
    }

    public function getSource()
    {
        return "{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}Calculator{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/bootstrap-datetimepicker.min.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">

{% block header %}
    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"{{ path('index') }}\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
{% endblock %}

<div class=\"container body-container\">
    {% block body %}
        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                {% block main %}{% endblock %}
            </div>
        </div>
    {% endblock %}
</div>


{% block javascripts %}
    <script src=\"{{ asset('js/jquery-2.2.4.min.js') }}\"></script>
    <script src=\"{{ asset('js/moment.min.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap-datetimepicker.min.js') }}\"></script>
{% endblock %}

</body>
</html>
";
    }
}
