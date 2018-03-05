<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_b2af302433542261fd6c7f9fa5f71206afb7af32aeb69a7847abe9c5b9c8d05b extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_f0242400130475d0d1454d2554dc3b955bf8b25f4419f12733010d1624a05beb = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f0242400130475d0d1454d2554dc3b955bf8b25f4419f12733010d1624a05beb->enter($__internal_f0242400130475d0d1454d2554dc3b955bf8b25f4419f12733010d1624a05beb_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_f0242400130475d0d1454d2554dc3b955bf8b25f4419f12733010d1624a05beb->leave($__internal_f0242400130475d0d1454d2554dc3b955bf8b25f4419f12733010d1624a05beb_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_a722e652772bddac3b46484e4e0e5d598411884c6336739be660e87afeeecb43 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a722e652772bddac3b46484e4e0e5d598411884c6336739be660e87afeeecb43->enter($__internal_a722e652772bddac3b46484e4e0e5d598411884c6336739be660e87afeeecb43_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_a722e652772bddac3b46484e4e0e5d598411884c6336739be660e87afeeecb43->leave($__internal_a722e652772bddac3b46484e4e0e5d598411884c6336739be660e87afeeecb43_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_1c76fdd981f4cb1d0bf99d5d2d399bb7a4dd71e1a6127ee1de7b823b7a037726 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1c76fdd981f4cb1d0bf99d5d2d399bb7a4dd71e1a6127ee1de7b823b7a037726->enter($__internal_1c76fdd981f4cb1d0bf99d5d2d399bb7a4dd71e1a6127ee1de7b823b7a037726_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_1c76fdd981f4cb1d0bf99d5d2d399bb7a4dd71e1a6127ee1de7b823b7a037726->leave($__internal_1c76fdd981f4cb1d0bf99d5d2d399bb7a4dd71e1a6127ee1de7b823b7a037726_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_096063fce17dec94f5e58ba879a27cec96c1d8b66b83190e1a783238cac40a63 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_096063fce17dec94f5e58ba879a27cec96c1d8b66b83190e1a783238cac40a63->enter($__internal_096063fce17dec94f5e58ba879a27cec96c1d8b66b83190e1a783238cac40a63_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_096063fce17dec94f5e58ba879a27cec96c1d8b66b83190e1a783238cac40a63->leave($__internal_096063fce17dec94f5e58ba879a27cec96c1d8b66b83190e1a783238cac40a63_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 13,  67 => 12,  56 => 7,  53 => 6,  47 => 5,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
";
    }
}
