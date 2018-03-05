<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_b8626280735b0356da087674450392044de90b7fcff64e85e6f33825f56264da extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
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
        $__internal_21180a230306e1a8b9b3725be78b50a822fd11962b127dc7ed0e805df3707e8c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_21180a230306e1a8b9b3725be78b50a822fd11962b127dc7ed0e805df3707e8c->enter($__internal_21180a230306e1a8b9b3725be78b50a822fd11962b127dc7ed0e805df3707e8c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_21180a230306e1a8b9b3725be78b50a822fd11962b127dc7ed0e805df3707e8c->leave($__internal_21180a230306e1a8b9b3725be78b50a822fd11962b127dc7ed0e805df3707e8c_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_48a1be2692c8e84ddbff085faa2a5a7ddace8c4a6106cd0c0c3ac4796f37b2e1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_48a1be2692c8e84ddbff085faa2a5a7ddace8c4a6106cd0c0c3ac4796f37b2e1->enter($__internal_48a1be2692c8e84ddbff085faa2a5a7ddace8c4a6106cd0c0c3ac4796f37b2e1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_48a1be2692c8e84ddbff085faa2a5a7ddace8c4a6106cd0c0c3ac4796f37b2e1->leave($__internal_48a1be2692c8e84ddbff085faa2a5a7ddace8c4a6106cd0c0c3ac4796f37b2e1_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_c97e3cc3789b370a4d41ac42aaf3d4e69070c580422024c71ee9ef8cf662f102 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c97e3cc3789b370a4d41ac42aaf3d4e69070c580422024c71ee9ef8cf662f102->enter($__internal_c97e3cc3789b370a4d41ac42aaf3d4e69070c580422024c71ee9ef8cf662f102_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_c97e3cc3789b370a4d41ac42aaf3d4e69070c580422024c71ee9ef8cf662f102->leave($__internal_c97e3cc3789b370a4d41ac42aaf3d4e69070c580422024c71ee9ef8cf662f102_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_50b236fb11d5ac2a3556af00b77853e87a73cce46415900f0ba62b83079e3145 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_50b236fb11d5ac2a3556af00b77853e87a73cce46415900f0ba62b83079e3145->enter($__internal_50b236fb11d5ac2a3556af00b77853e87a73cce46415900f0ba62b83079e3145_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_50b236fb11d5ac2a3556af00b77853e87a73cce46415900f0ba62b83079e3145->leave($__internal_50b236fb11d5ac2a3556af00b77853e87a73cce46415900f0ba62b83079e3145_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  117 => 33,  114 => 32,  108 => 28,  106 => 27,  102 => 25,  96 => 24,  88 => 21,  82 => 17,  80 => 16,  75 => 14,  70 => 13,  64 => 12,  54 => 9,  48 => 6,  45 => 5,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
";
    }
}
