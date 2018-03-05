<?php

/* article/article.html.twig */
class __TwigTemplate_217763af051f505fa32909467b1b4f3a85a462934f5c7d868cca75f870f5316a extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "article/article.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_d48b9dff22246ee896a28334cb4e048ef15b3ff3b2202c9bf9ac454c60c2d598 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d48b9dff22246ee896a28334cb4e048ef15b3ff3b2202c9bf9ac454c60c2d598->enter($__internal_d48b9dff22246ee896a28334cb4e048ef15b3ff3b2202c9bf9ac454c60c2d598_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "article/article.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_d48b9dff22246ee896a28334cb4e048ef15b3ff3b2202c9bf9ac454c60c2d598->leave($__internal_d48b9dff22246ee896a28334cb4e048ef15b3ff3b2202c9bf9ac454c60c2d598_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_f56e8c75321fa6fec2148318418751aa2f7229e50eed26ddc9147305bd987106 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f56e8c75321fa6fec2148318418751aa2f7229e50eed26ddc9147305bd987106->enter($__internal_f56e8c75321fa6fec2148318418751aa2f7229e50eed26ddc9147305bd987106_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "    <div class=\"container body-content\">
        <div class=\"row\">
            <div class=\"col-md-12\">
                <article>
                    <header>
                        <h2>";
        // line 9
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["article"]) ? $context["article"] : $this->getContext($context, "article")), "title", array()), "html", null, true);
        echo "</h2>
                    </header>

                    <p>
                        ";
        // line 13
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["article"]) ? $context["article"] : $this->getContext($context, "article")), "content", array()), "html", null, true);
        echo "
                    </p>

                    <small class=\"author\">
                        ";
        // line 17
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["article"]) ? $context["article"] : $this->getContext($context, "article")), "author", array()), "html", null, true);
        echo "
                    </small>

                    <footer>
                        <div class=\"pull-right\">
                            <a class=\"btn btn-default btn-xs\" href=\"";
        // line 22
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("blog_index");
        echo "\">back &raquo;</a>
                        </div>
                    </footer>
                </article>
            </div>
        </div>
    </div>

";
        
        $__internal_f56e8c75321fa6fec2148318418751aa2f7229e50eed26ddc9147305bd987106->leave($__internal_f56e8c75321fa6fec2148318418751aa2f7229e50eed26ddc9147305bd987106_prof);

    }

    public function getTemplateName()
    {
        return "article/article.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  69 => 22,  61 => 17,  54 => 13,  47 => 9,  40 => 4,  34 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends 'base.html.twig' %}

{% block main %}
    <div class=\"container body-content\">
        <div class=\"row\">
            <div class=\"col-md-12\">
                <article>
                    <header>
                        <h2>{{ article.title }}</h2>
                    </header>

                    <p>
                        {{ article.content }}
                    </p>

                    <small class=\"author\">
                        {{ article.author }}
                    </small>

                    <footer>
                        <div class=\"pull-right\">
                            <a class=\"btn btn-default btn-xs\" href=\"{{ path('blog_index') }}\">back &raquo;</a>
                        </div>
                    </footer>
                </article>
            </div>
        </div>
    </div>

{% endblock %}";
    }
}
