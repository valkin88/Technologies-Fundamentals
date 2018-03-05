<?php

/* base.html.twig */
class __TwigTemplate_7a5f57f9b6bd704e1c01312df5d061de82e5722fa0c3fddabb3b73214a708a6e extends Twig_Template
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
            'footer' => array($this, 'block_footer'),
            'javascripts' => array($this, 'block_javascripts'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_67ddddd53f10d691284ce3a55cf5e94f7f79bbd65336968a7c38fa8057b12ce7 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_67ddddd53f10d691284ce3a55cf5e94f7f79bbd65336968a7c38fa8057b12ce7->enter($__internal_67ddddd53f10d691284ce3a55cf5e94f7f79bbd65336968a7c38fa8057b12ce7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

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
        // line 70
        echo "
<div class=\"container body-container\">
    ";
        // line 72
        $this->displayBlock('body', $context, $blocks);
        // line 79
        echo "</div>

";
        // line 81
        $this->displayBlock('footer', $context, $blocks);
        // line 88
        echo "
";
        // line 89
        $this->displayBlock('javascripts', $context, $blocks);
        // line 95
        echo "
</body>
</html>
";
        
        $__internal_67ddddd53f10d691284ce3a55cf5e94f7f79bbd65336968a7c38fa8057b12ce7->leave($__internal_67ddddd53f10d691284ce3a55cf5e94f7f79bbd65336968a7c38fa8057b12ce7_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_5ceb0d2720d50632a9fa2f680ddc0d87f69b24ced4a76a0c4778f08366e2406e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5ceb0d2720d50632a9fa2f680ddc0d87f69b24ced4a76a0c4778f08366e2406e->enter($__internal_5ceb0d2720d50632a9fa2f680ddc0d87f69b24ced4a76a0c4778f08366e2406e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "SoftUni Blog";
        
        $__internal_5ceb0d2720d50632a9fa2f680ddc0d87f69b24ced4a76a0c4778f08366e2406e->leave($__internal_5ceb0d2720d50632a9fa2f680ddc0d87f69b24ced4a76a0c4778f08366e2406e_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_75a3c117a0b8380d2001fe6184e8edf7a732d19e4012a4a480f8ac6f03eb9f50 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_75a3c117a0b8380d2001fe6184e8edf7a732d19e4012a4a480f8ac6f03eb9f50->enter($__internal_75a3c117a0b8380d2001fe6184e8edf7a732d19e4012a4a480f8ac6f03eb9f50_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/bootstrap-datetimepicker.min.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_75a3c117a0b8380d2001fe6184e8edf7a732d19e4012a4a480f8ac6f03eb9f50->leave($__internal_75a3c117a0b8380d2001fe6184e8edf7a732d19e4012a4a480f8ac6f03eb9f50_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_a231fd882977284e0afefb8e631287f76e82a1f489e6a73e89252bb154cb8ac4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a231fd882977284e0afefb8e631287f76e82a1f489e6a73e89252bb154cb8ac4->enter($__internal_a231fd882977284e0afefb8e631287f76e82a1f489e6a73e89252bb154cb8ac4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_a231fd882977284e0afefb8e631287f76e82a1f489e6a73e89252bb154cb8ac4->leave($__internal_a231fd882977284e0afefb8e631287f76e82a1f489e6a73e89252bb154cb8ac4_prof);

    }

    // line 21
    public function block_header($context, array $blocks = array())
    {
        $__internal_74b912f0a5f74c8345c588e0b46f219d1faa2d15e0238e8ce45ac207296f0785 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_74b912f0a5f74c8345c588e0b46f219d1faa2d15e0238e8ce45ac207296f0785->enter($__internal_74b912f0a5f74c8345c588e0b46f219d1faa2d15e0238e8ce45ac207296f0785_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        // line 22
        echo "    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"";
        // line 26
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("blog_index");
        echo "\" class=\"navbar-brand\">SOFTUNI BLOG</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>
                <div class=\"navbar-collapse collapse\">
                    <ul class=\"nav navbar-nav navbar-right\">
                        ";
        // line 36
        if ($this->getAttribute((isset($context["app"]) ? $context["app"] : $this->getContext($context, "app")), "user", array())) {
            // line 37
            echo "                            <li>
                                <a href=\"";
            // line 38
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("article_create");
            echo "\">
                                    Create Article
                                </a>
                            </li>
                            <li>
                                <a href=\"";
            // line 43
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("user_profile");
            echo "\">
                                    My Profile
                                </a>
                            </li>
                            <li>
                                <a href=\"";
            // line 48
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("security_logout");
            echo "\">
                                    Logout
                                </a>
                            </li>
                        ";
        } else {
            // line 53
            echo "                            <li>
                                <a href=\"";
            // line 54
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("user_register");
            echo "\">
                                    REGISTER
                                </a>
                            </li>
                            <li>
                                <a href=\"";
            // line 59
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("security_login");
            echo "\">
                                    LOGIN
                                </a>
                            </li>
                        ";
        }
        // line 64
        echo "                    </ul>
                </div>
            </div>
        </div>
    </header>
";
        
        $__internal_74b912f0a5f74c8345c588e0b46f219d1faa2d15e0238e8ce45ac207296f0785->leave($__internal_74b912f0a5f74c8345c588e0b46f219d1faa2d15e0238e8ce45ac207296f0785_prof);

    }

    // line 72
    public function block_body($context, array $blocks = array())
    {
        $__internal_5cb4546d932d6349b2152caafd5b33629a32022535a55db4c48d296adb3137da = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5cb4546d932d6349b2152caafd5b33629a32022535a55db4c48d296adb3137da->enter($__internal_5cb4546d932d6349b2152caafd5b33629a32022535a55db4c48d296adb3137da_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 73
        echo "        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                ";
        // line 75
        $this->displayBlock('main', $context, $blocks);
        // line 76
        echo "            </div>
        </div>
    ";
        
        $__internal_5cb4546d932d6349b2152caafd5b33629a32022535a55db4c48d296adb3137da->leave($__internal_5cb4546d932d6349b2152caafd5b33629a32022535a55db4c48d296adb3137da_prof);

    }

    // line 75
    public function block_main($context, array $blocks = array())
    {
        $__internal_f045d8d0b46034b24fe5983a894115d7e7aef0f162539b72af9f66bb7432f6d3 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f045d8d0b46034b24fe5983a894115d7e7aef0f162539b72af9f66bb7432f6d3->enter($__internal_f045d8d0b46034b24fe5983a894115d7e7aef0f162539b72af9f66bb7432f6d3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_f045d8d0b46034b24fe5983a894115d7e7aef0f162539b72af9f66bb7432f6d3->leave($__internal_f045d8d0b46034b24fe5983a894115d7e7aef0f162539b72af9f66bb7432f6d3_prof);

    }

    // line 81
    public function block_footer($context, array $blocks = array())
    {
        $__internal_e0501682cdb87b9402aefbd2fedf2b89f8c04b7ab19145e3dfa36da3b2ba2408 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e0501682cdb87b9402aefbd2fedf2b89f8c04b7ab19145e3dfa36da3b2ba2408->enter($__internal_e0501682cdb87b9402aefbd2fedf2b89f8c04b7ab19145e3dfa36da3b2ba2408_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "footer"));

        // line 82
        echo "    <footer>
        <div class=\"container modal-footer\">
            <p>&copy; 2016 - Software University Foundation</p>
        </div>
    </footer>
";
        
        $__internal_e0501682cdb87b9402aefbd2fedf2b89f8c04b7ab19145e3dfa36da3b2ba2408->leave($__internal_e0501682cdb87b9402aefbd2fedf2b89f8c04b7ab19145e3dfa36da3b2ba2408_prof);

    }

    // line 89
    public function block_javascripts($context, array $blocks = array())
    {
        $__internal_77652649e0533cabc7820ffa6708c91d65f7f583c13b290c85577f6753f4d250 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_77652649e0533cabc7820ffa6708c91d65f7f583c13b290c85577f6753f4d250->enter($__internal_77652649e0533cabc7820ffa6708c91d65f7f583c13b290c85577f6753f4d250_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        // line 90
        echo "    <script src=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/jquery-2.2.4.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 91
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/moment.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 92
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 93
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap-datetimepicker.min.js"), "html", null, true);
        echo "\"></script>
";
        
        $__internal_77652649e0533cabc7820ffa6708c91d65f7f583c13b290c85577f6753f4d250->leave($__internal_77652649e0533cabc7820ffa6708c91d65f7f583c13b290c85577f6753f4d250_prof);

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
        return array (  281 => 93,  277 => 92,  273 => 91,  268 => 90,  262 => 89,  250 => 82,  244 => 81,  233 => 75,  224 => 76,  222 => 75,  218 => 73,  212 => 72,  200 => 64,  192 => 59,  184 => 54,  181 => 53,  173 => 48,  165 => 43,  157 => 38,  154 => 37,  152 => 36,  139 => 26,  133 => 22,  127 => 21,  116 => 19,  107 => 14,  102 => 13,  96 => 12,  84 => 11,  74 => 95,  72 => 89,  69 => 88,  67 => 81,  63 => 79,  61 => 72,  57 => 70,  55 => 21,  50 => 19,  43 => 16,  41 => 12,  37 => 11,  30 => 6,);
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
    <title>{% block title %}SoftUni Blog{% endblock %}</title>
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
                    <a href=\"{{ path('blog_index') }}\" class=\"navbar-brand\">SOFTUNI BLOG</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>
                <div class=\"navbar-collapse collapse\">
                    <ul class=\"nav navbar-nav navbar-right\">
                        {% if app.user %}
                            <li>
                                <a href=\"{{ path('article_create') }}\">
                                    Create Article
                                </a>
                            </li>
                            <li>
                                <a href=\"{{ path('user_profile') }}\">
                                    My Profile
                                </a>
                            </li>
                            <li>
                                <a href=\"{{ path('security_logout') }}\">
                                    Logout
                                </a>
                            </li>
                        {% else %}
                            <li>
                                <a href=\"{{ path('user_register') }}\">
                                    REGISTER
                                </a>
                            </li>
                            <li>
                                <a href=\"{{ path('security_login') }}\">
                                    LOGIN
                                </a>
                            </li>
                        {% endif %}
                    </ul>
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

{% block footer %}
    <footer>
        <div class=\"container modal-footer\">
            <p>&copy; 2016 - Software University Foundation</p>
        </div>
    </footer>
{% endblock %}

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
