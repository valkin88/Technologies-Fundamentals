<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_2ba968935d24069744dbea8bc5110c1bdc8d4c05b1877347d70ae7c2a7ea3853 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@Twig/layout.html.twig", "@Twig/Exception/exception_full.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'title' => array($this, 'block_title'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@Twig/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_bbb91862f5c73f37520dcfc26159cc8208a098e037ef227ff9d9e57675c3e278 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_bbb91862f5c73f37520dcfc26159cc8208a098e037ef227ff9d9e57675c3e278->enter($__internal_bbb91862f5c73f37520dcfc26159cc8208a098e037ef227ff9d9e57675c3e278_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_bbb91862f5c73f37520dcfc26159cc8208a098e037ef227ff9d9e57675c3e278->leave($__internal_bbb91862f5c73f37520dcfc26159cc8208a098e037ef227ff9d9e57675c3e278_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_d76361a99f26d3756aaedcbd0958679c7572c56d4ddcb47677c206bc0325f20e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d76361a99f26d3756aaedcbd0958679c7572c56d4ddcb47677c206bc0325f20e->enter($__internal_d76361a99f26d3756aaedcbd0958679c7572c56d4ddcb47677c206bc0325f20e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <link href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpFoundationExtension')->generateAbsoluteUrl($this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("bundles/framework/css/exception.css")), "html", null, true);
        echo "\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
";
        
        $__internal_d76361a99f26d3756aaedcbd0958679c7572c56d4ddcb47677c206bc0325f20e->leave($__internal_d76361a99f26d3756aaedcbd0958679c7572c56d4ddcb47677c206bc0325f20e_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_4890e7e0f18133e59983848dadf1beb83cf8a44b93116fd7bf6cabd353d8a5e0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4890e7e0f18133e59983848dadf1beb83cf8a44b93116fd7bf6cabd353d8a5e0->enter($__internal_4890e7e0f18133e59983848dadf1beb83cf8a44b93116fd7bf6cabd353d8a5e0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 8
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["exception"]) ? $context["exception"] : $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, (isset($context["status_code"]) ? $context["status_code"] : $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, (isset($context["status_text"]) ? $context["status_text"] : $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_4890e7e0f18133e59983848dadf1beb83cf8a44b93116fd7bf6cabd353d8a5e0->leave($__internal_4890e7e0f18133e59983848dadf1beb83cf8a44b93116fd7bf6cabd353d8a5e0_prof);

    }

    // line 11
    public function block_body($context, array $blocks = array())
    {
        $__internal_ed38ff8bdec01df5f11bd41b59e4ff03f38f5655e2fd3edb3b64c1e73d46e09c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ed38ff8bdec01df5f11bd41b59e4ff03f38f5655e2fd3edb3b64c1e73d46e09c->enter($__internal_ed38ff8bdec01df5f11bd41b59e4ff03f38f5655e2fd3edb3b64c1e73d46e09c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 12
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 12)->display($context);
        
        $__internal_ed38ff8bdec01df5f11bd41b59e4ff03f38f5655e2fd3edb3b64c1e73d46e09c->leave($__internal_ed38ff8bdec01df5f11bd41b59e4ff03f38f5655e2fd3edb3b64c1e73d46e09c_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/Exception/exception_full.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  78 => 12,  72 => 11,  58 => 8,  52 => 7,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@Twig/layout.html.twig' %}

{% block head %}
    <link href=\"{{ absolute_url(asset('bundles/framework/css/exception.css')) }}\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
{% endblock %}

{% block title %}
    {{ exception.message }} ({{ status_code }} {{ status_text }})
{% endblock %}

{% block body %}
    {% include '@Twig/Exception/exception.html.twig' %}
{% endblock %}
";
    }
}
